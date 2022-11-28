namespace RecepcionBodega
{
    partial class FormAñadirSalida
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.ptbLogo2 = new System.Windows.Forms.PictureBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblUnidad = new System.Windows.Forms.Label();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.rtxbObservaciones = new System.Windows.Forms.RichTextBox();
            this.txbCantidad = new System.Windows.Forms.TextBox();
            this.txbDestino = new System.Windows.Forms.TextBox();
            this.txbLote = new System.Windows.Forms.TextBox();
            this.dtpFechaSalida = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo2)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.btnCancelar);
            this.splitContainer1.Panel1.Controls.Add(this.ptbLogo2);
            this.splitContainer1.Panel1.Controls.Add(this.btnAceptar);
            this.splitContainer1.Panel1.Controls.Add(this.btnLimpiar);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lblUnidad);
            this.splitContainer1.Panel2.Controls.Add(this.cmbProducto);
            this.splitContainer1.Panel2.Controls.Add(this.rtxbObservaciones);
            this.splitContainer1.Panel2.Controls.Add(this.txbCantidad);
            this.splitContainer1.Panel2.Controls.Add(this.txbDestino);
            this.splitContainer1.Panel2.Controls.Add(this.txbLote);
            this.splitContainer1.Panel2.Controls.Add(this.dtpFechaSalida);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(622, 373);
            this.splitContainer1.SplitterDistance = 151;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(15, 237);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(115, 45);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // ptbLogo2
            // 
            this.ptbLogo2.Image = global::RecepcionBodega.Properties.Resources.logoIES;
            this.ptbLogo2.InitialImage = global::RecepcionBodega.Properties.Resources.logoIES;
            this.ptbLogo2.Location = new System.Drawing.Point(15, 15);
            this.ptbLogo2.Name = "ptbLogo2";
            this.ptbLogo2.Size = new System.Drawing.Size(115, 122);
            this.ptbLogo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbLogo2.TabIndex = 22;
            this.ptbLogo2.TabStop = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(15, 166);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(115, 41);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(15, 305);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(115, 47);
            this.btnLimpiar.TabIndex = 9;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblUnidad
            // 
            this.lblUnidad.AutoSize = true;
            this.lblUnidad.Location = new System.Drawing.Point(317, 172);
            this.lblUnidad.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblUnidad.Name = "lblUnidad";
            this.lblUnidad.Size = new System.Drawing.Size(35, 13);
            this.lblUnidad.TabIndex = 34;
            this.lblUnidad.Text = "label7";
            // 
            // cmbProducto
            // 
            this.cmbProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Location = new System.Drawing.Point(148, 30);
            this.cmbProducto.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(270, 21);
            this.cmbProducto.TabIndex = 1;
            this.cmbProducto.SelectedIndexChanged += new System.EventHandler(this.cmbProducto_SelectedIndexChanged);
            // 
            // rtxbObservaciones
            // 
            this.rtxbObservaciones.Location = new System.Drawing.Point(148, 253);
            this.rtxbObservaciones.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.rtxbObservaciones.Name = "rtxbObservaciones";
            this.rtxbObservaciones.Size = new System.Drawing.Size(263, 56);
            this.rtxbObservaciones.TabIndex = 6;
            this.rtxbObservaciones.Text = "";
            // 
            // txbCantidad
            // 
            this.txbCantidad.Location = new System.Drawing.Point(148, 169);
            this.txbCantidad.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.txbCantidad.Name = "txbCantidad";
            this.txbCantidad.Size = new System.Drawing.Size(154, 20);
            this.txbCantidad.TabIndex = 4;
            // 
            // txbDestino
            // 
            this.txbDestino.Location = new System.Drawing.Point(148, 211);
            this.txbDestino.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.txbDestino.Name = "txbDestino";
            this.txbDestino.Size = new System.Drawing.Size(263, 20);
            this.txbDestino.TabIndex = 5;
            // 
            // txbLote
            // 
            this.txbLote.Location = new System.Drawing.Point(148, 130);
            this.txbLote.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.txbLote.Name = "txbLote";
            this.txbLote.Size = new System.Drawing.Size(263, 20);
            this.txbLote.TabIndex = 3;
            // 
            // dtpFechaSalida
            // 
            this.dtpFechaSalida.Location = new System.Drawing.Point(148, 82);
            this.dtpFechaSalida.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.dtpFechaSalida.Name = "dtpFechaSalida";
            this.dtpFechaSalida.Size = new System.Drawing.Size(263, 20);
            this.dtpFechaSalida.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 172);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Cantidad:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 253);
            this.label6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Observaciones:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 211);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Destino:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 130);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Lote:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Fecha de salida:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Producto:";
            // 
            // FormAñadirSalida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 373);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormAñadirSalida";
            this.Text = "FormAñadirSalida";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAñadirSalida_FormClosed);
            this.Load += new System.EventHandler(this.FormAñadirSalida_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.PictureBox ptbLogo2;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.RichTextBox rtxbObservaciones;
        private System.Windows.Forms.TextBox txbCantidad;
        private System.Windows.Forms.TextBox txbDestino;
        private System.Windows.Forms.TextBox txbLote;
        private System.Windows.Forms.DateTimePicker dtpFechaSalida;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.Label lblUnidad;
    }
}