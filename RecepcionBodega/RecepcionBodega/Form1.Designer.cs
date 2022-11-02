namespace RecepcionBodega
{
    partial class FormPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnVerProductos = new System.Windows.Forms.Button();
            this.btnAnnadirProducto = new System.Windows.Forms.Button();
            this.btnAnnadirSalida = new System.Windows.Forms.Button();
            this.ptbLogo2 = new System.Windows.Forms.PictureBox();
            this.btnAnnadirEntrada = new System.Windows.Forms.Button();
            this.ptbLogo = new System.Windows.Forms.PictureBox();
            this.rbSalidas = new System.Windows.Forms.RadioButton();
            this.rbEntradas = new System.Windows.Forms.RadioButton();
            this.txbLote = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.lblLote = new System.Windows.Forms.Label();
            this.lblHasta = new System.Windows.Forms.Label();
            this.lblDesde = new System.Windows.Forms.Label();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.lblProducto = new System.Windows.Forms.Label();
            this.lblFiltros = new System.Windows.Forms.Label();
            this.dgvTabla = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnSalir);
            this.splitContainer1.Panel1.Controls.Add(this.btnVerProductos);
            this.splitContainer1.Panel1.Controls.Add(this.btnAnnadirProducto);
            this.splitContainer1.Panel1.Controls.Add(this.btnAnnadirSalida);
            this.splitContainer1.Panel1.Controls.Add(this.ptbLogo2);
            this.splitContainer1.Panel1.Controls.Add(this.btnAnnadirEntrada);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ptbLogo);
            this.splitContainer1.Panel2.Controls.Add(this.rbSalidas);
            this.splitContainer1.Panel2.Controls.Add(this.rbEntradas);
            this.splitContainer1.Panel2.Controls.Add(this.txbLote);
            this.splitContainer1.Panel2.Controls.Add(this.btnLimpiar);
            this.splitContainer1.Panel2.Controls.Add(this.btnFiltrar);
            this.splitContainer1.Panel2.Controls.Add(this.dtpHasta);
            this.splitContainer1.Panel2.Controls.Add(this.dtpDesde);
            this.splitContainer1.Panel2.Controls.Add(this.lblLote);
            this.splitContainer1.Panel2.Controls.Add(this.lblHasta);
            this.splitContainer1.Panel2.Controls.Add(this.lblDesde);
            this.splitContainer1.Panel2.Controls.Add(this.cmbProducto);
            this.splitContainer1.Panel2.Controls.Add(this.lblProducto);
            this.splitContainer1.Panel2.Controls.Add(this.lblFiltros);
            this.splitContainer1.Panel2.Controls.Add(this.dgvTabla);
            this.splitContainer1.Panel2.Controls.Add(this.lblTitulo);
            this.splitContainer1.Size = new System.Drawing.Size(1064, 581);
            this.splitContainer1.SplitterDistance = 190;
            this.splitContainer1.TabIndex = 2;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(25, 520);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(148, 47);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnVerProductos
            // 
            this.btnVerProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerProductos.Location = new System.Drawing.Point(25, 339);
            this.btnVerProductos.Name = "btnVerProductos";
            this.btnVerProductos.Size = new System.Drawing.Size(148, 47);
            this.btnVerProductos.TabIndex = 3;
            this.btnVerProductos.Text = "Ver Productos";
            this.btnVerProductos.UseVisualStyleBackColor = true;
            this.btnVerProductos.Click += new System.EventHandler(this.btnVerProductos_Click);
            // 
            // btnAnnadirProducto
            // 
            this.btnAnnadirProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnadirProducto.Location = new System.Drawing.Point(25, 286);
            this.btnAnnadirProducto.Name = "btnAnnadirProducto";
            this.btnAnnadirProducto.Size = new System.Drawing.Size(148, 47);
            this.btnAnnadirProducto.TabIndex = 2;
            this.btnAnnadirProducto.Text = "Añadir Producto";
            this.btnAnnadirProducto.UseVisualStyleBackColor = true;
            this.btnAnnadirProducto.Click += new System.EventHandler(this.btnAnnadirProducto_Click);
            // 
            // btnAnnadirSalida
            // 
            this.btnAnnadirSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnadirSalida.Location = new System.Drawing.Point(25, 233);
            this.btnAnnadirSalida.Name = "btnAnnadirSalida";
            this.btnAnnadirSalida.Size = new System.Drawing.Size(148, 47);
            this.btnAnnadirSalida.TabIndex = 1;
            this.btnAnnadirSalida.Text = "Añadir Salida";
            this.btnAnnadirSalida.UseVisualStyleBackColor = true;
            this.btnAnnadirSalida.Click += new System.EventHandler(this.btnAnnadirSalida_Click);
            // 
            // ptbLogo2
            // 
            this.ptbLogo2.Image = global::RecepcionBodega.Properties.Resources.logoIES;
            this.ptbLogo2.InitialImage = global::RecepcionBodega.Properties.Resources.logoIES;
            this.ptbLogo2.Location = new System.Drawing.Point(14, 8);
            this.ptbLogo2.Name = "ptbLogo2";
            this.ptbLogo2.Size = new System.Drawing.Size(159, 161);
            this.ptbLogo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbLogo2.TabIndex = 15;
            this.ptbLogo2.TabStop = false;
            // 
            // btnAnnadirEntrada
            // 
            this.btnAnnadirEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnadirEntrada.Location = new System.Drawing.Point(25, 180);
            this.btnAnnadirEntrada.Name = "btnAnnadirEntrada";
            this.btnAnnadirEntrada.Size = new System.Drawing.Size(148, 47);
            this.btnAnnadirEntrada.TabIndex = 0;
            this.btnAnnadirEntrada.Text = "Añadir Entrada";
            this.btnAnnadirEntrada.UseVisualStyleBackColor = true;
            this.btnAnnadirEntrada.Click += new System.EventHandler(this.btnAnnadirEntrada_Click);
            // 
            // ptbLogo
            // 
            this.ptbLogo.Image = global::RecepcionBodega.Properties.Resources.logoDptoIndAli;
            this.ptbLogo.InitialImage = global::RecepcionBodega.Properties.Resources.logoDptoIndAli;
            this.ptbLogo.Location = new System.Drawing.Point(634, 419);
            this.ptbLogo.Name = "ptbLogo";
            this.ptbLogo.Size = new System.Drawing.Size(148, 148);
            this.ptbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbLogo.TabIndex = 5;
            this.ptbLogo.TabStop = false;
            // 
            // rbSalidas
            // 
            this.rbSalidas.AutoSize = true;
            this.rbSalidas.Location = new System.Drawing.Point(709, 31);
            this.rbSalidas.Name = "rbSalidas";
            this.rbSalidas.Size = new System.Drawing.Size(59, 17);
            this.rbSalidas.TabIndex = 18;
            this.rbSalidas.TabStop = true;
            this.rbSalidas.Text = "Salidas";
            this.rbSalidas.UseVisualStyleBackColor = true;
            this.rbSalidas.CheckedChanged += new System.EventHandler(this.rbSalidas_CheckedChanged);
            // 
            // rbEntradas
            // 
            this.rbEntradas.AutoSize = true;
            this.rbEntradas.Checked = true;
            this.rbEntradas.Location = new System.Drawing.Point(578, 31);
            this.rbEntradas.Name = "rbEntradas";
            this.rbEntradas.Size = new System.Drawing.Size(67, 17);
            this.rbEntradas.TabIndex = 17;
            this.rbEntradas.TabStop = true;
            this.rbEntradas.Text = "Entradas";
            this.rbEntradas.UseVisualStyleBackColor = true;
            this.rbEntradas.CheckedChanged += new System.EventHandler(this.rbEntradas_CheckedChanged);
            // 
            // txbLote
            // 
            this.txbLote.Location = new System.Drawing.Point(634, 223);
            this.txbLote.Name = "txbLote";
            this.txbLote.Size = new System.Drawing.Size(100, 20);
            this.txbLote.TabIndex = 16;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(728, 288);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(121, 35);
            this.btnLimpiar.TabIndex = 14;
            this.btnLimpiar.Text = "Limpiar Filtros";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(587, 288);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(121, 35);
            this.btnFiltrar.TabIndex = 13;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // dtpHasta
            // 
            this.dtpHasta.Location = new System.Drawing.Point(634, 181);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(200, 20);
            this.dtpHasta.TabIndex = 11;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Location = new System.Drawing.Point(633, 141);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(200, 20);
            this.dtpDesde.TabIndex = 10;
            // 
            // lblLote
            // 
            this.lblLote.AutoSize = true;
            this.lblLote.Location = new System.Drawing.Point(576, 230);
            this.lblLote.Name = "lblLote";
            this.lblLote.Size = new System.Drawing.Size(31, 13);
            this.lblLote.TabIndex = 9;
            this.lblLote.Text = "Lote:";
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(575, 187);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(38, 13);
            this.lblHasta.TabIndex = 8;
            this.lblHasta.Text = "Hasta:";
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(575, 148);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(41, 13);
            this.lblDesde.TabIndex = 7;
            this.lblDesde.Text = "Desde:";
            // 
            // cmbProducto
            // 
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Location = new System.Drawing.Point(634, 103);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(121, 21);
            this.cmbProducto.TabIndex = 6;
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(575, 111);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(53, 13);
            this.lblProducto.TabIndex = 5;
            this.lblProducto.Text = "Producto:";
            // 
            // lblFiltros
            // 
            this.lblFiltros.AutoSize = true;
            this.lblFiltros.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltros.Location = new System.Drawing.Point(576, 70);
            this.lblFiltros.Name = "lblFiltros";
            this.lblFiltros.Size = new System.Drawing.Size(50, 17);
            this.lblFiltros.TabIndex = 2;
            this.lblFiltros.Text = "Filtros:";
            // 
            // dgvTabla
            // 
            this.dgvTabla.AllowUserToAddRows = false;
            this.dgvTabla.AllowUserToDeleteRows = false;
            this.dgvTabla.AllowUserToResizeColumns = false;
            this.dgvTabla.AllowUserToResizeRows = false;
            this.dgvTabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabla.Location = new System.Drawing.Point(7, 30);
            this.dgvTabla.MultiSelect = false;
            this.dgvTabla.Name = "dgvTabla";
            this.dgvTabla.ReadOnly = true;
            this.dgvTabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTabla.Size = new System.Drawing.Size(539, 536);
            this.dgvTabla.TabIndex = 1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(175, 8);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(57, 17);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "lblTitulo";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 581);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormPrincipal";
            this.Text = "Libro de Registros de Productos Enológicos";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnVerProductos;
        private System.Windows.Forms.Button btnAnnadirProducto;
        private System.Windows.Forms.Button btnAnnadirSalida;
        private System.Windows.Forms.Button btnAnnadirEntrada;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvTabla;
        private System.Windows.Forms.PictureBox ptbLogo;
        private System.Windows.Forms.TextBox txbLote;
        private System.Windows.Forms.PictureBox ptbLogo2;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label lblLote;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label lblFiltros;
        private System.Windows.Forms.RadioButton rbSalidas;
        private System.Windows.Forms.RadioButton rbEntradas;
    }
}

