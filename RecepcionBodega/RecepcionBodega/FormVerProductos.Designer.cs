namespace RecepcionBodega
{
    partial class FormVerProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.ptbLogo2 = new System.Windows.Forms.PictureBox();
            this.lblStockUnidad = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.ptbImgProducto = new System.Windows.Forms.PictureBox();
            this.dgvTabla = new System.Windows.Forms.DataGridView();
            this.customInstaller1 = new MySql.Data.MySqlClient.CustomInstaller();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImgProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnCerrar);
            this.splitContainer1.Panel1.Controls.Add(this.ptbLogo2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lblStockUnidad);
            this.splitContainer1.Panel2.Controls.Add(this.lblNombre);
            this.splitContainer1.Panel2.Controls.Add(this.ptbImgProducto);
            this.splitContainer1.Panel2.Controls.Add(this.dgvTabla);
            this.splitContainer1.Size = new System.Drawing.Size(782, 464);
            this.splitContainer1.SplitterDistance = 184;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(12, 385);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(148, 47);
            this.btnCerrar.TabIndex = 17;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // ptbLogo2
            // 
            this.ptbLogo2.Image = global::RecepcionBodega.Properties.Resources.logoIES;
            this.ptbLogo2.InitialImage = global::RecepcionBodega.Properties.Resources.logoIES;
            this.ptbLogo2.Location = new System.Drawing.Point(12, 12);
            this.ptbLogo2.Name = "ptbLogo2";
            this.ptbLogo2.Size = new System.Drawing.Size(159, 161);
            this.ptbLogo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbLogo2.TabIndex = 16;
            this.ptbLogo2.TabStop = false;
            // 
            // lblStockUnidad
            // 
            this.lblStockUnidad.AutoSize = true;
            this.lblStockUnidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockUnidad.Location = new System.Drawing.Point(474, 215);
            this.lblStockUnidad.Name = "lblStockUnidad";
            this.lblStockUnidad.Size = new System.Drawing.Size(41, 16);
            this.lblStockUnidad.TabIndex = 21;
            this.lblStockUnidad.Text = "Stock";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(474, 188);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 16);
            this.lblNombre.TabIndex = 19;
            this.lblNombre.Text = "Nombre";
            // 
            // ptbImgProducto
            // 
            this.ptbImgProducto.Image = global::RecepcionBodega.Properties.Resources.logoIES;
            this.ptbImgProducto.InitialImage = global::RecepcionBodega.Properties.Resources.logoIES;
            this.ptbImgProducto.Location = new System.Drawing.Point(423, 12);
            this.ptbImgProducto.Name = "ptbImgProducto";
            this.ptbImgProducto.Size = new System.Drawing.Size(159, 161);
            this.ptbImgProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbImgProducto.TabIndex = 18;
            this.ptbImgProducto.TabStop = false;
            // 
            // dgvTabla
            // 
            this.dgvTabla.AllowUserToAddRows = false;
            this.dgvTabla.AllowUserToDeleteRows = false;
            this.dgvTabla.AllowUserToResizeColumns = false;
            this.dgvTabla.AllowUserToResizeRows = false;
            this.dgvTabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabla.Location = new System.Drawing.Point(14, 12);
            this.dgvTabla.MultiSelect = false;
            this.dgvTabla.Name = "dgvTabla";
            this.dgvTabla.ReadOnly = true;
            this.dgvTabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTabla.Size = new System.Drawing.Size(279, 440);
            this.dgvTabla.TabIndex = 2;
            // 
            // FormVerProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 464);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormVerProductos";
            this.Text = "FormVerProductos";
            this.Load += new System.EventHandler(this.FormVerProductos_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImgProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox ptbLogo2;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridView dgvTabla;
        private MySql.Data.MySqlClient.CustomInstaller customInstaller1;
        private System.Windows.Forms.PictureBox ptbImgProducto;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblStockUnidad;
    }
}