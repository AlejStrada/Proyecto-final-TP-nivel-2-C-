using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;
using validaciones;



namespace presentacion
{
    public partial class frmPrincipal : Form
    {
        private List<Articulo> listaArticulos;
        private HelperPresentacion helper = new HelperPresentacion();   

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            cargar();
            cargaCategoria();
            cargaMarca();
            cboMarca.Enabled= false;
            cboCategoria.Enabled = false;
            cboMarca.Text = "";
            cboCategoria.Text = "";
            cboPrecios.Enabled = false;
          
            cboPrecios.Items.Add("Mayor a");
            cboPrecios.Items.Add("Menor a");
            cboPrecios.Items.Add("Igual a");
            cboPrecios.SelectedIndex = 0;
            txtRangoPrecios.Enabled = false;
            btnFiltroAvanzado.Visible = false;
            grbBusqueda.Enabled = false;
           

        }

        private void cargaCategoria()
        {
            
            CategoriaNegocio categorias = new CategoriaNegocio();
            cboCategoria.DataSource = categorias.ListaCategoria();
            cboCategoria.ValueMember = "Id";
            cboCategoria.DisplayMember = "Descripcion";
        }
        private void cargaMarca()
        {
            MarcaNegocio marcas = new MarcaNegocio();
            cboMarca.DataSource = marcas.ListaMarcas();
            cboMarca.ValueMember = "Id";
            cboMarca.DisplayMember = "Descripcion";
        }
        private void cargar()
        {
            ArticuloNegocio carga = new ArticuloNegocio();
            try
            {
                listaArticulos = carga.Listar();
                dgvDatos.DataSource = carga.Listar();
                formatoColumnas();
                pcbImagen.Load(listaArticulos[0].ImagenUrl);
                helper.cargarImagen(listaArticulos[0].ImagenUrl , pcbImagen);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void formatoColumnas()
        {
            dgvDatos.Columns["ImagenUrl"].Visible = false;
            dgvDatos.Columns["IdCategoria"].Visible = false;
            dgvDatos.Columns["IdMarca"].Visible = false;
            dgvDatos.Columns["Descripcion"].Visible = false;
            dgvDatos.Columns["Id"].Visible = false;
            dgvDatos.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDatos.Columns["Precio"].DefaultCellStyle.Format = ("C2");
        }

     
        private void dgvDatos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDatos.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvDatos.CurrentRow.DataBoundItem;
                helper.cargarImagen(seleccionado.ImagenUrl, pcbImagen);
                lblNombre.Text="Nombre: "+ seleccionado.Nombre.ToUpper();
                lblMarca.Text ="Marca: " + seleccionado.Marca.Descripcion.ToUpper();
                lblDescripcion.Text = "Descripcion: " + seleccionado.Descripcion;
                lblPrecio.Text= "Precio: $"+ seleccionado.Precio.ToString("#.##");

            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregar agregar = new frmAgregar();
            agregar.ShowDialog();
            cargar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo seleccion;
            seleccion = (Articulo)dgvDatos.CurrentRow.DataBoundItem;
            frmAgregar modificar = new frmAgregar(seleccion);
            modificar.ShowDialog();
            cargar();
        }

                    
        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> filtroArticulos;
            string filtro = txtBusqueda.Text;
            if (filtro.Length >= 3)
            {
                filtroArticulos = listaArticulos.FindAll(f => f.Nombre.ToUpper().Contains(filtro.ToUpper()) || f.Marca.Descripcion.ToUpper().Contains(filtro.ToUpper()) || f.Categoria.Descripcion.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                filtroArticulos = listaArticulos;

            }

            dgvDatos.DataSource = null;
            dgvDatos.DataSource = filtroArticulos;
            formatoColumnas();
        }

            
        private void filtroMarca()
        {
            List<Articulo> filtroAvanzadoMarca;
            if (rdbMarca.Checked)
            {
            string filtro = cboMarca.SelectedItem.ToString();
            filtroAvanzadoMarca = listaArticulos.FindAll(f => f.Marca.Descripcion.Contains(filtro));
            dgvDatos.DataSource = filtroAvanzadoMarca;
            formatoColumnas();
            }           
        }
        private void filtroCategoria()
        {
            List<Articulo> filtroAvanzadoCategoria;
            if (rdbCategoria.Checked)
            {
                string filtro = cboCategoria.SelectedItem.ToString();
                filtroAvanzadoCategoria = listaArticulos.FindAll(f => f.Categoria.Descripcion.Contains(filtro));
                dgvDatos.DataSource = filtroAvanzadoCategoria;
                formatoColumnas();
           }
        }


   
        private void rdbMarca_CheckedChanged(object sender, EventArgs e)
            {
            try
            {
                if (rdbMarca.Checked)
                {
                    cboMarca.Enabled = true;
                    cboCategoria.Text = "";

                }                    
                else
                {
                    cboMarca.Enabled = false;
                    dgvDatos.DataSource = null;
                    dgvDatos.DataSource = listaArticulos;
                    formatoColumnas();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void rdbCategoria_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rdbCategoria.Checked)
                {
                    cboCategoria.Enabled = true;
                    cboMarca.Text = "";

                }
                else
                {
                 cboCategoria.Enabled = false;
                    dgvDatos.DataSource = null;
                    dgvDatos.DataSource = listaArticulos;
                    formatoColumnas();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void cboMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
           filtroMarca();
        }

        private void cboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtroCategoria();
        }

        private void rbtPrecios_CheckedChanged(object sender, EventArgs e)
        {
            cboPrecios.SelectedIndex = 0;   
            if (rbtPrecios.Checked)
            {
            cboPrecios.Enabled = true;
            txtRangoPrecios.Enabled = true;              
            btnFiltroAvanzado.Visible= true;
            }
            else
            {
                cboPrecios.Enabled = false;
                txtRangoPrecios.Enabled = false;
                btnFiltroAvanzado.Visible = false;
            }        
                   
        }

           private void btnFiltroAvanzado_Click(object sender, EventArgs e)
        {
            ArticuloNegocio filtroNegocio = new ArticuloNegocio();
            Validar validarNumero = new Validar();
            try
            {
                string rangoPrecios = cboPrecios.SelectedItem.ToString();
                string filtroPrecios = txtRangoPrecios.Text;  
                if (!validarNumero.soloNumeros(txtRangoPrecios.Text))
                {
                    MessageBox.Show("Ingrese solo numeros");
                    txtRangoPrecios.Clear();
                    return; //el return corta el evento
                }
               
                dgvDatos.DataSource = filtroNegocio.filtroPrecios(rangoPrecios,filtroPrecios);
              
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
          
        private void chkAvanzada_CheckedChanged(object sender, EventArgs e)
        {
            if (grbBusqueda.Enabled)
            {
                grbBusqueda.Enabled = false;
                dgvDatos.DataSource = null;
                dgvDatos.DataSource = listaArticulos;
                formatoColumnas();
            }
            else grbBusqueda.Enabled = true;
        }

        private void txtBusqueda_Enter(object sender, EventArgs e)
        {
            chkAvanzada.Checked = false;
            txtBusqueda.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio eliminarNegocio = new ArticuloNegocio();
            Articulo seleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("¿Desea eliminar este articulo de la base de datos?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Articulo)dgvDatos.CurrentRow.DataBoundItem;
                    eliminarNegocio.eliminar(seleccionado.Id);
                    cargar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
    
}
    

