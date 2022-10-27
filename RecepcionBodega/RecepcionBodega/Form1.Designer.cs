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
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.btnAnnadirEntrada);
            this.splitContainer1.Size = new System.Drawing.Size(993, 579);
            this.splitContainer1.SplitterDistance = 223;
            this.splitContainer1.TabIndex = 2;
            // 
            // btnAnnadirEntrada
            // 
            this.btnAnnadirEntrada.Location = new System.Drawing.Point(37, 31);
            this.btnAnnadirEntrada.Name = "btnAnnadirEntrada";
            this.btnAnnadirEntrada.Size = new System.Drawing.Size(148, 47);
            this.btnAnnadirEntrada.TabIndex = 0;
            this.btnAnnadirEntrada.Text = "Añadir Entrada";
            this.btnAnnadirEntrada.UseVisualStyleBackColor = true;
            this.btnAnnadirEntrada.Click += new System.EventHandler(this.btnAnnadirEntrada_Click);
            // 
            // btnAnnadirSalida
            // 
            this.btnAnnadirSalida.Location = new System.Drawing.Point(37, 84);
            this.btnAnnadirSalida.Name = "btnAnnadirSalida";
            this.btnAnnadirSalida.Size = new System.Drawing.Size(148, 47);
            this.btnAnnadirSalida.TabIndex = 1;
            this.btnAnnadirSalida.Text = "Añadir Salida";
            this.btnAnnadirSalida.UseVisualStyleBackColor = true;
            this.btnAnnadirSalida.Click += new System.EventHandler(this.btnAnnadirSalida_Click);
            // 
            // btnAnnadirProducto
            // 
            this.btnAnnadirProducto.Location = new System.Drawing.Point(37, 137);
            this.btnAnnadirProducto.Name = "btnAnnadirProducto";
            this.btnAnnadirProducto.Size = new System.Drawing.Size(148, 47);
            this.btnAnnadirProducto.TabIndex = 2;
            this.btnAnnadirProducto.Text = "Añadir Producto";
            this.btnAnnadirProducto.UseVisualStyleBackColor = true;
            this.btnAnnadirProducto.Click += new System.EventHandler(this.btnAnnadirProducto_Click);
            // 
            // btnVerProductos
            // 
            this.btnVerProductos.Location = new System.Drawing.Point(37, 190);
            this.btnVerProductos.Name = "btnVerProductos";
            this.btnVerProductos.Size = new System.Drawing.Size(148, 47);
            this.btnVerProductos.TabIndex = 3;
            this.btnVerProductos.Text = "Ver Productos";
            this.btnVerProductos.UseVisualStyleBackColor = true;
            this.btnVerProductos.Click += new System.EventHandler(this.btnVerProductos_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(37, 484);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(148, 47);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 579);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormPrincipal";
            this.Text = "Libro de Registros de Productos Enológicos";
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
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
    }
}

