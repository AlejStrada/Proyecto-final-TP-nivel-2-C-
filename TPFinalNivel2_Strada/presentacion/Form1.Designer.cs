namespace presentacion
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.grbBusqueda = new System.Windows.Forms.GroupBox();
            this.lblFiltroPrecio = new System.Windows.Forms.Label();
            this.btnFiltroAvanzado = new System.Windows.Forms.Button();
            this.txtRangoPrecios = new System.Windows.Forms.TextBox();
            this.cboPrecios = new System.Windows.Forms.ComboBox();
            this.rbtPrecios = new System.Windows.Forms.RadioButton();
            this.rdbCategoria = new System.Windows.Forms.RadioButton();
            this.rdbMarca = new System.Windows.Forms.RadioButton();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.chkAvanzada = new System.Windows.Forms.CheckBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.pcbImagen = new System.Windows.Forms.PictureBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblNombreDb = new System.Windows.Forms.Label();
            this.lblMarcaDb = new System.Windows.Forms.Label();
            this.lblPrecioDb = new System.Windows.Forms.Label();
            this.txtDescripcionDb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.grbBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.AllowUserToResizeColumns = false;
            this.dgvDatos.AllowUserToResizeRows = false;
            this.dgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDatos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDatos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.dgvDatos.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvDatos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle25.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.dgvDatos.ColumnHeadersHeight = 30;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle26.NullValue = null;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDatos.DefaultCellStyle = dataGridViewCellStyle26;
            this.dgvDatos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvDatos.EnableHeadersVisualStyles = false;
            this.dgvDatos.Location = new System.Drawing.Point(17, 173);
            this.dgvDatos.MultiSelect = false;
            this.dgvDatos.Name = "dgvDatos";
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle27.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.dgvDatos.RowHeadersVisible = false;
            this.dgvDatos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDatos.RowsDefaultCellStyle = dataGridViewCellStyle28;
            this.dgvDatos.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatos.Size = new System.Drawing.Size(457, 231);
            this.dgvDatos.TabIndex = 3;
            this.dgvDatos.SelectionChanged += new System.EventHandler(this.dgvDatos_SelectionChanged);
            // 
            // grbBusqueda
            // 
            this.grbBusqueda.BackColor = System.Drawing.SystemColors.Window;
            this.grbBusqueda.Controls.Add(this.lblFiltroPrecio);
            this.grbBusqueda.Controls.Add(this.btnFiltroAvanzado);
            this.grbBusqueda.Controls.Add(this.txtRangoPrecios);
            this.grbBusqueda.Controls.Add(this.cboPrecios);
            this.grbBusqueda.Controls.Add(this.rbtPrecios);
            this.grbBusqueda.Controls.Add(this.rdbCategoria);
            this.grbBusqueda.Controls.Add(this.rdbMarca);
            this.grbBusqueda.Controls.Add(this.cboCategoria);
            this.grbBusqueda.Controls.Add(this.cboMarca);
            this.grbBusqueda.Location = new System.Drawing.Point(17, 60);
            this.grbBusqueda.Name = "grbBusqueda";
            this.grbBusqueda.Size = new System.Drawing.Size(457, 107);
            this.grbBusqueda.TabIndex = 15;
            this.grbBusqueda.TabStop = false;
            this.grbBusqueda.Text = "Busqueda avanzada";
            // 
            // lblFiltroPrecio
            // 
            this.lblFiltroPrecio.AutoSize = true;
            this.lblFiltroPrecio.Location = new System.Drawing.Point(218, 76);
            this.lblFiltroPrecio.Name = "lblFiltroPrecio";
            this.lblFiltroPrecio.Size = new System.Drawing.Size(13, 13);
            this.lblFiltroPrecio.TabIndex = 19;
            this.lblFiltroPrecio.Text = "$";
            // 
            // btnFiltroAvanzado
            // 
            this.btnFiltroAvanzado.Location = new System.Drawing.Point(311, 73);
            this.btnFiltroAvanzado.Name = "btnFiltroAvanzado";
            this.btnFiltroAvanzado.Size = new System.Drawing.Size(90, 20);
            this.btnFiltroAvanzado.TabIndex = 18;
            this.btnFiltroAvanzado.Text = "Buscar";
            this.btnFiltroAvanzado.UseVisualStyleBackColor = true;
            this.btnFiltroAvanzado.Click += new System.EventHandler(this.btnFiltroAvanzado_Click);
            // 
            // txtRangoPrecios
            // 
            this.txtRangoPrecios.Location = new System.Drawing.Point(233, 73);
            this.txtRangoPrecios.Name = "txtRangoPrecios";
            this.txtRangoPrecios.Size = new System.Drawing.Size(72, 20);
            this.txtRangoPrecios.TabIndex = 17;
            this.txtRangoPrecios.Tag = "";
            // 
            // cboPrecios
            // 
            this.cboPrecios.AccessibleDescription = "";
            this.cboPrecios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPrecios.FormattingEnabled = true;
            this.cboPrecios.Location = new System.Drawing.Point(118, 72);
            this.cboPrecios.Name = "cboPrecios";
            this.cboPrecios.Size = new System.Drawing.Size(90, 21);
            this.cboPrecios.TabIndex = 16;
            // 
            // rbtPrecios
            // 
            this.rbtPrecios.AutoSize = true;
            this.rbtPrecios.Location = new System.Drawing.Point(10, 76);
            this.rbtPrecios.Name = "rbtPrecios";
            this.rbtPrecios.Size = new System.Drawing.Size(109, 17);
            this.rbtPrecios.TabIndex = 15;
            this.rbtPrecios.TabStop = true;
            this.rbtPrecios.Text = "Rango de precios";
            this.rbtPrecios.UseVisualStyleBackColor = true;
            this.rbtPrecios.CheckedChanged += new System.EventHandler(this.rbtPrecios_CheckedChanged);
            // 
            // rdbCategoria
            // 
            this.rdbCategoria.AutoSize = true;
            this.rdbCategoria.Location = new System.Drawing.Point(10, 49);
            this.rdbCategoria.Name = "rdbCategoria";
            this.rdbCategoria.Size = new System.Drawing.Size(70, 17);
            this.rdbCategoria.TabIndex = 14;
            this.rdbCategoria.TabStop = true;
            this.rdbCategoria.Text = "Categoria";
            this.rdbCategoria.UseVisualStyleBackColor = true;
            this.rdbCategoria.CheckedChanged += new System.EventHandler(this.rdbCategoria_CheckedChanged);
            // 
            // rdbMarca
            // 
            this.rdbMarca.AutoSize = true;
            this.rdbMarca.Location = new System.Drawing.Point(10, 23);
            this.rdbMarca.Name = "rdbMarca";
            this.rdbMarca.Size = new System.Drawing.Size(55, 17);
            this.rdbMarca.TabIndex = 13;
            this.rdbMarca.Text = "Marca";
            this.rdbMarca.UseVisualStyleBackColor = true;
            this.rdbMarca.CheckedChanged += new System.EventHandler(this.rdbMarca_CheckedChanged);
            // 
            // cboCategoria
            // 
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(118, 45);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(90, 21);
            this.cboCategoria.TabIndex = 7;
            this.cboCategoria.SelectedIndexChanged += new System.EventHandler(this.cboCategoria_SelectedIndexChanged);
            // 
            // cboMarca
            // 
            this.cboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(118, 19);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(90, 21);
            this.cboMarca.TabIndex = 6;
            this.cboMarca.SelectedIndexChanged += new System.EventHandler(this.cboMarca_SelectedIndexChanged);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.Control;
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEliminar.Location = new System.Drawing.Point(185, 410);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 35);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar articulo";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(17, 410);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 35);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar articulo";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(98, 410);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 35);
            this.btnModificar.TabIndex = 9;
            this.btnModificar.Text = "Modificar articulo";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // chkAvanzada
            // 
            this.chkAvanzada.AutoSize = true;
            this.chkAvanzada.Location = new System.Drawing.Point(350, 29);
            this.chkAvanzada.Name = "chkAvanzada";
            this.chkAvanzada.Size = new System.Drawing.Size(124, 17);
            this.chkAvanzada.TabIndex = 19;
            this.chkAvanzada.Text = "Busqueda avanzada";
            this.chkAvanzada.UseVisualStyleBackColor = true;
            this.chkAvanzada.CheckedChanged += new System.EventHandler(this.chkAvanzada_CheckedChanged);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(21, 31);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(90, 13);
            this.lblBuscar.TabIndex = 16;
            this.lblBuscar.Text = "Busqueda rapida ";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(117, 27);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(227, 20);
            this.txtBusqueda.TabIndex = 2;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            this.txtBusqueda.Enter += new System.EventHandler(this.txtBusqueda_Enter);
            // 
            // pcbImagen
            // 
            this.pcbImagen.ErrorImage = null;
            this.pcbImagen.Location = new System.Drawing.Point(499, 66);
            this.pcbImagen.Name = "pcbImagen";
            this.pcbImagen.Size = new System.Drawing.Size(209, 209);
            this.pcbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbImagen.TabIndex = 1;
            this.pcbImagen.TabStop = false;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.Color.Black;
            this.lblDescripcion.Location = new System.Drawing.Point(501, 357);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(89, 21);
            this.lblDescripcion.TabIndex = 20;
            this.lblDescripcion.Text = "descripcion";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.ForeColor = System.Drawing.Color.Black;
            this.lblMarca.Location = new System.Drawing.Point(501, 308);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(51, 15);
            this.lblMarca.TabIndex = 21;
            this.lblMarca.Text = "Marca ";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.ForeColor = System.Drawing.Color.Black;
            this.lblPrecio.Location = new System.Drawing.Point(501, 334);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(47, 15);
            this.lblPrecio.TabIndex = 22;
            this.lblPrecio.Text = "precio";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.Black;
            this.lblNombre.Location = new System.Drawing.Point(501, 282);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(58, 15);
            this.lblNombre.TabIndex = 23;
            this.lblNombre.Text = "Nombre";
            // 
            // lblNombreDb
            // 
            this.lblNombreDb.AutoSize = true;
            this.lblNombreDb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreDb.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblNombreDb.Location = new System.Drawing.Point(565, 277);
            this.lblNombreDb.Name = "lblNombreDb";
            this.lblNombreDb.Size = new System.Drawing.Size(57, 20);
            this.lblNombreDb.TabIndex = 24;
            this.lblNombreDb.Text = "label1";
            // 
            // lblMarcaDb
            // 
            this.lblMarcaDb.AutoSize = true;
            this.lblMarcaDb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcaDb.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblMarcaDb.Location = new System.Drawing.Point(565, 303);
            this.lblMarcaDb.Name = "lblMarcaDb";
            this.lblMarcaDb.Size = new System.Drawing.Size(57, 20);
            this.lblMarcaDb.TabIndex = 25;
            this.lblMarcaDb.Text = "label2";
            // 
            // lblPrecioDb
            // 
            this.lblPrecioDb.AutoSize = true;
            this.lblPrecioDb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioDb.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblPrecioDb.Location = new System.Drawing.Point(565, 329);
            this.lblPrecioDb.Name = "lblPrecioDb";
            this.lblPrecioDb.Size = new System.Drawing.Size(57, 20);
            this.lblPrecioDb.TabIndex = 26;
            this.lblPrecioDb.Text = "label3";
            // 
            // txtDescripcionDb
            // 
            this.txtDescripcionDb.BackColor = System.Drawing.SystemColors.Control;
            this.txtDescripcionDb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescripcionDb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionDb.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtDescripcionDb.Location = new System.Drawing.Point(504, 381);
            this.txtDescripcionDb.Multiline = true;
            this.txtDescripcionDb.Name = "txtDescripcionDb";
            this.txtDescripcionDb.ReadOnly = true;
            this.txtDescripcionDb.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDescripcionDb.Size = new System.Drawing.Size(202, 55);
            this.txtDescripcionDb.TabIndex = 28;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(718, 462);
            this.Controls.Add(this.txtDescripcionDb);
            this.Controls.Add(this.lblPrecioDb);
            this.Controls.Add(this.lblMarcaDb);
            this.Controls.Add(this.lblNombreDb);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.chkAvanzada);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.grbBusqueda);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.pcbImagen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CATALOGO DE ARTICULOS";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.grbBusqueda.ResumeLayout(false);
            this.grbBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pcbImagen;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.RadioButton rdbCategoria;
        private System.Windows.Forms.RadioButton rdbMarca;
        private System.Windows.Forms.GroupBox grbBusqueda;
        private System.Windows.Forms.RadioButton rbtPrecios;
        private System.Windows.Forms.ComboBox cboPrecios;
        private System.Windows.Forms.TextBox txtRangoPrecios;
        private System.Windows.Forms.Button btnFiltroAvanzado;
        private System.Windows.Forms.Label lblFiltroPrecio;
        private System.Windows.Forms.CheckBox chkAvanzada;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblNombreDb;
        private System.Windows.Forms.Label lblMarcaDb;
        private System.Windows.Forms.Label lblPrecioDb;
        private System.Windows.Forms.TextBox txtDescripcionDb;
    }
}

