using dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using negocio;
using System.Diagnostics.Eventing.Reader;
using System.Text.RegularExpressions;
using System.IO;
using System.Configuration;
using validaciones;

namespace presentacion
{
    public partial class frmAgregar : Form
    {
        private Articulo articulo = null;
        private OpenFileDialog archivo = null;
        private HelperPresentacion helper = new HelperPresentacion();
        private Validar validaciones = new Validar();
        public frmAgregar()
        {
            InitializeComponent();
        }

        public frmAgregar(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "MODIFICAR ARTICULO";

        }

        

        private void frmAgregar_Load(object sender, EventArgs e)
        {
            CategoriaNegocio Categoria= new CategoriaNegocio();
            MarcaNegocio Marca = new MarcaNegocio();
            try
            {
                //precarga de desplegables si hay q agregar un articulo nuevo
                cboCategoria.DataSource = Categoria.ListaCategoria();
                cboCategoria.ValueMember = "Id";    
                cboCategoria.DisplayMember = "Descripcion";
                cboMarca.DataSource = Marca.ListaMarcas();
                cboMarca.ValueMember = "Id";
                cboMarca.DisplayMember="Descripcion";

            if (articulo != null) //precarga de datos selcionados para modificar
                {
                txtCodigo.Text = articulo.Codigo;
                txtNombre.Text = articulo.Nombre;
                txtPrecio.Text = articulo.Precio.ToString("#.##");
                txtImagen.Text = articulo.ImagenUrl;
                cboMarca.SelectedValue = articulo.Marca.Id;
                cboCategoria.SelectedValue = articulo.Categoria.Id;
                txtDescripcion.Text = articulo.Descripcion;
                helper.cargarImagen(articulo.ImagenUrl, pcbImagenArticulo);
                
                }
               

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void txtImagen_TextChanged(object sender, EventArgs e)
        {
            helper.cargarImagen(txtImagen.Text, pcbImagenArticulo);
        }
        
        private void txtImagen_Leave(object sender, EventArgs e)
        {
            helper.cargarImagen(txtImagen.Text, pcbImagenArticulo);
                       
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            try
            {
                

                if (articulo == null)
                   articulo = new Articulo();

                if (validaciones.requeridos(txtCodigo.Text.ToString()))
                {
                    MessageBox.Show("Ingrese un codigo de articulo....");
                    lblCodigo.ForeColor = Color.Red;
                    return;
                }else lblCodigo.ForeColor=Color.Black;

                if (validaciones.requeridos(txtNombre.Text.ToString()))
                {
                    MessageBox.Show("Ingrese un nombre de articulo....");
                    lblNombre.ForeColor = Color.Red;
                    return;
                }else lblNombre.ForeColor = Color.Black;
                

                if (!validaciones.soloNumeros(txtPrecio.Text))
                {
                    MessageBox.Show("Ingrese solo numeros...");
                    lblPrecio.ForeColor = Color.Red;
                    txtPrecio.Clear();
                    return;
                }else lblPrecio.ForeColor = Color.Black;
                

                if (validaciones.requeridos(txtPrecio.Text.ToString()))
                {
                    MessageBox.Show("Ingrese un precio al articulo....");
                    lblPrecio.ForeColor = Color.Red;
                    return;
                }else lblPrecio.ForeColor = Color.Black;
                

                articulo.Codigo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.Precio = decimal.Parse(txtPrecio.Text);
                articulo.Categoria= (Categoria)cboCategoria.SelectedItem;
                articulo.Marca= (Marca)cboMarca.SelectedItem;
                articulo.ImagenUrl = txtImagen.Text;

               
                if (articulo.Id != 0)
                {
                    articuloNegocio.modificarArticulo(articulo);
                    MessageBox.Show("Se modifico el articulo en la base de datos");
                }
                else {
                    articuloNegocio.agregarArticulo(articulo);
                    MessageBox.Show("Se agrego el articulo a la base de datos");
                      }

                if (archivo != null && !(txtImagen.Text.ToUpper().Contains("HTTP"))) 
                {
                    File.Copy(archivo.FileName, ConfigurationManager.AppSettings["appArticulos"] + archivo.SafeFileName); 
                }
                Close();
           }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
               
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg;|png|*.png";
            if (archivo.ShowDialog() == DialogResult.OK) //si el cuadro de dialogo cargo una imagen y se pulso aceptar
            {
                txtImagen.Text = archivo.FileName;
                helper.cargarImagen(archivo.FileName , pcbImagenArticulo);
            }
        }

        private void txtCodigo_Leave(object sender, EventArgs e)
        {
            if (validaciones.requeridos(txtCodigo.Text.ToString()))
            {
                MessageBox.Show("Solo nros para filtrar por un campo numérico...");
             }
        }

        private void txtImagen_Enter(object sender, EventArgs e)
        {
            txtImagen.Clear();
        }
    }
}
