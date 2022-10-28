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
            this.btnAnnadirEntrada = new System.Windows.Forms.Button();
            this.btnAnnadirSalida = new System.Windows.Forms.Button();
            this.btnAnnadirProducto = new System.Windows.Forms.Button();
            this.btnVerProductos = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblFiltros = new System.Windows.Forms.Label();
            this.chbEntrada = new System.Windows.Forms.CheckBox();
            this.chbSalida = new System.Windows.Forms.CheckBox();
            this.lblProducto = new System.Windows.Forms.Label();
            this.txbProducto = new System.Windows.Forms.ComboBox();
            this.lblDesde = new System.Windows.Forms.Label();
            this.lblHasta = new System.Windows.Forms.Label();
            this.lblLote = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.ptbLogo2 = new System.Windows.Forms.PictureBox();
            this.ptbLogo = new System.Windows.Forms.PictureBox();
            this.txbLote = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.ptbLogo);
            this.splitContainer1.Panel1.Controls.Add(this.btnSalir);
            this.splitContainer1.Panel1.Controls.Add(this.btnVerProductos);
            this.splitContainer1.Panel1.Controls.Add(this.btnAnnadirProducto);
            this.splitContainer1.Panel1.Controls.Add(this.btnAnnadirSalida);
            this.splitContainer1.Panel1.Controls.Add(this.btnAnnadirEntrada);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txbLote);
            this.splitContainer1.Panel2.Controls.Add(this.ptbLogo2);
            this.splitContainer1.Panel2.Controls.Add(this.btnLimpiar);
            this.splitContainer1.Panel2.Controls.Add(this.btnFiltrar);
            this.splitContainer1.Panel2.Controls.Add(this.dtpHasta);
            this.splitContainer1.Panel2.Controls.Add(this.dtpDesde);
            this.splitContainer1.Panel2.Controls.Add(this.lblLote);
            this.splitContainer1.Panel2.Controls.Add(this.lblHasta);
            this.splitContainer1.Panel2.Controls.Add(this.lblDesde);
            this.splitContainer1.Panel2.Controls.Add(this.txbProducto);
            this.splitContainer1.Panel2.Controls.Add(this.lblProducto);
            this.splitContainer1.Panel2.Controls.Add(this.chbSalida);
            this.splitContainer1.Panel2.Controls.Add(this.chbEntrada);
            this.splitContainer1.Panel2.Controls.Add(this.lblFiltros);
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Panel2.Controls.Add(this.lblTitulo);
            this.splitContainer1.Size = new System.Drawing.Size(1064, 581);
            this.splitContainer1.SplitterDistance = 190;
            this.splitContainer1.TabIndex = 2;
            // 
            // btnAnnadirEntrada
            // 
            this.btnAnnadirEntrada.Location = new System.Drawing.Point(25, 180);
            this.btnAnnadirEntrada.Name = "btnAnnadirEntrada";
            this.btnAnnadirEntrada.Size = new System.Drawing.Size(148, 47);
            this.btnAnnadirEntrada.TabIndex = 0;
            this.btnAnnadirEntrada.Text = "Añadir Entrada";
            this.btnAnnadirEntrada.UseVisualStyleBackColor = true;
            this.btnAnnadirEntrada.Click += new System.EventHandler(this.btnAnnadirEntrada_Click);
            // 
            // btnAnnadirSalida
            // 
            this.btnAnnadirSalida.Location = new System.Drawing.Point(25, 233);
            this.btnAnnadirSalida.Name = "btnAnnadirSalida";
            this.btnAnnadirSalida.Size = new System.Drawing.Size(148, 47);
            this.btnAnnadirSalida.TabIndex = 1;
            this.btnAnnadirSalida.Text = "Añadir Salida";
            this.btnAnnadirSalida.UseVisualStyleBackColor = true;
            this.btnAnnadirSalida.Click += new System.EventHandler(this.btnAnnadirSalida_Click);
            // 
            // btnAnnadirProducto
            // 
            this.btnAnnadirProducto.Location = new System.Drawing.Point(25, 286);
            this.btnAnnadirProducto.Name = "btnAnnadirProducto";
            this.btnAnnadirProducto.Size = new System.Drawing.Size(148, 47);
            this.btnAnnadirProducto.TabIndex = 2;
            this.btnAnnadirProducto.Text = "Añadir Producto";
            this.btnAnnadirProducto.UseVisualStyleBackColor = true;
            this.btnAnnadirProducto.Click += new System.EventHandler(this.btnAnnadirProducto_Click);
            // 
            // btnVerProductos
            // 
            this.btnVerProductos.Location = new System.Drawing.Point(25, 339);
            this.btnVerProductos.Name = "btnVerProductos";
            this.btnVerProductos.Size = new System.Drawing.Size(148, 47);
            this.btnVerProductos.TabIndex = 3;
            this.btnVerProductos.Text = "Ver Productos";
            this.btnVerProductos.UseVisualStyleBackColor = true;
            this.btnVerProductos.Click += new System.EventHandler(this.btnVerProductos_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(25, 520);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(148, 47);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(3, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(187, 13);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Entrada/Salida de producto enológico";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(539, 536);
            this.dataGridView1.TabIndex = 1;
            // 
            // lblFiltros
            // 
            this.lblFiltros.AutoSize = true;
            this.lblFiltros.Location = new System.Drawing.Point(575, 9);
            this.lblFiltros.Name = "lblFiltros";
            this.lblFiltros.Size = new System.Drawing.Size(37, 13);
            this.lblFiltros.TabIndex = 2;
            this.lblFiltros.Text = "Filtros:";
            // 
            // chbEntrada
            // 
            this.chbEntrada.AutoSize = true;
            this.chbEntrada.Location = new System.Drawing.Point(578, 31);
            this.chbEntrada.Name = "chbEntrada";
            this.chbEntrada.Size = new System.Drawing.Size(68, 17);
            this.chbEntrada.TabIndex = 3;
            this.chbEntrada.Text = "Entradas";
            this.chbEntrada.UseVisualStyleBackColor = true;
            // 
            // chbSalida
            // 
            this.chbSalida.AutoSize = true;
            this.chbSalida.Location = new System.Drawing.Point(578, 54);
            this.chbSalida.Name = "chbSalida";
            this.chbSalida.Size = new System.Drawing.Size(60, 17);
            this.chbSalida.TabIndex = 4;
            this.chbSalida.Text = "Salidas";
            this.chbSalida.UseVisualStyleBackColor = true;
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
            // txbProducto
            // 
            this.txbProducto.FormattingEnabled = true;
            this.txbProducto.Location = new System.Drawing.Point(634, 103);
            this.txbProducto.Name = "txbProducto";
            this.txbProducto.Size = new System.Drawing.Size(121, 21);
            this.txbProducto.TabIndex = 6;
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
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(575, 187);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(38, 13);
            this.lblHasta.TabIndex = 8;
            this.lblHasta.Text = "Hasta:";
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
            // dtpDesde
            // 
            this.dtpDesde.Location = new System.Drawing.Point(633, 141);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(200, 20);
            this.dtpDesde.TabIndex = 10;
            // 
            // dtpHasta
            // 
            this.dtpHasta.Location = new System.Drawing.Point(634, 181);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(200, 20);
            this.dtpHasta.TabIndex = 11;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(587, 288);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(121, 35);
            this.btnFiltrar.TabIndex = 13;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
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
            // ptbLogo2
            // 
            this.ptbLogo2.Image = global::RecepcionBodega.Properties.Resources.logoIES;
            this.ptbLogo2.InitialImage = global::RecepcionBodega.Properties.Resources.logoIES;
            this.ptbLogo2.Location = new System.Drawing.Point(644, 417);
            this.ptbLogo2.Name = "ptbLogo2";
            this.ptbLogo2.Size = new System.Drawing.Size(150, 150);
            this.ptbLogo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbLogo2.TabIndex = 15;
            this.ptbLogo2.TabStop = false;
            // 
            // ptbLogo
            // 
            this.ptbLogo.Image = global::RecepcionBodega.Properties.Resources.logoDptoIndAli;
            this.ptbLogo.InitialImage = global::RecepcionBodega.Properties.Resources.logoDptoIndAli;
            this.ptbLogo.Location = new System.Drawing.Point(25, 13);
            this.ptbLogo.Name = "ptbLogo";
            this.ptbLogo.Size = new System.Drawing.Size(148, 148);
            this.ptbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbLogo.TabIndex = 5;
            this.ptbLogo.TabStop = false;
            // 
            // txbLote
            // 
            this.txbLote.Location = new System.Drawing.Point(634, 223);
            this.txbLote.Name = "txbLote";
            this.txbLote.Size = new System.Drawing.Size(100, 20);
            this.txbLote.TabIndex = 16;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 581);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormPrincipal";
            this.Text = "Libro de Registros de Productos Enológicos";
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
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
        private System.Windows.Forms.ComboBox txbProducto;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.CheckBox chbSalida;
        private System.Windows.Forms.CheckBox chbEntrada;
        private System.Windows.Forms.Label lblFiltros;
    }
}

