using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RecepcionBodega
{
    // Formulario realizado por Juan
    public partial class FormAñadirProductos : Form
    {
        Boolean imagenCambiada;
        MySqlConnection dbconn = null;

        public FormAñadirProductos()
        {
            InitializeComponent();
            LoadStyle();
            dbconn = new MySqlConnection(Properties.Settings.Default.dbconnection);
            imagenCambiada = false;
        }

        private void btnExplorar_Click(object sender, EventArgs e)
        {
            filExplorar.Filter = "Archivos de imagen (*.jpg;*.png;*.bmp)|*.jpg;*.png;*.bmp"
            + "|Archivos JPEG (*.jpg)|*.jpg"
            + "|Archivos PNG (*.png)|*.png"
            + "|Archivos BMP (*.bmp)|*.bmp"
            ;

            if (filExplorar.ShowDialog() == DialogResult.OK)
            {
                Bitmap imagen = new Bitmap(filExplorar.FileName);
                pcbImagen.Image = imagen;
                imagenCambiada = true;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            string dir = Path.GetDirectoryName(Application.ExecutablePath);
            string filename = Path.Combine(dir, @"..\..\img\nofotos.png");
            Image imgReturn = Image.FromFile(filename);
            pcbImagen.Image = imgReturn;
            txbNombre.Text = "";
            txbUnidad.Text = "";
            imagenCambiada = false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(txbNombre.Text.Length < 1)
            {
                MessageBox.Show("No has introducido el nombre del producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if(txbUnidad.Text.Length < 1)
            {
                MessageBox.Show("No has introducido la unidad del producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                if (imagenCambiada)
                {
                    dbconn.Open();

                    string query = "INSERT INTO producto (nombre, unidad, imagen) VALUES('" + txbNombre.Text + "' , '" + txbUnidad.Text + "' , " + "@Image" + ")";
                    MySqlCommand commandDatabase = new MySqlCommand(query, dbconn);

                    var image = pcbImagen.Image;
                    using (var ms = new MemoryStream())
                    {
                        image.Save(ms, image.RawFormat);
                        commandDatabase.Parameters.Add("@Image", MySqlDbType.VarBinary).Value = ms.ToArray();
                    }

                    commandDatabase.ExecuteNonQuery();
                    dbconn.Close();
                } else
                {
                    dbconn.Open();
                    string query = "INSERT INTO producto (nombre, unidad) VALUES('" + txbNombre.Text + "' , '" + txbUnidad.Text + "' )";
                    MySqlCommand commandDatabase = new MySqlCommand(query, dbconn);
                    commandDatabase.ExecuteNonQuery();
                    dbconn.Close();
                }

                MessageBox.Show("El producto ha sido añadido correctamente.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        // Funcion reutilizada del formulario principal realizada por Antonio
        private void LoadStyle()
        {
            splitContainer1.Panel2.BackColor = Properties.Settings.Default.color_ventana;
            splitContainer1.Panel1.BackColor = Properties.Settings.Default.color_menu;

            txbNombre.Font = Properties.Settings.Default.fuente_letra;
            lblNombre.Font = Properties.Settings.Default.fuente_letra;
            lblUnidad.Font = Properties.Settings.Default.fuente_letra;
            txbUnidad.Font = Properties.Settings.Default.fuente_letra;
            btnExplorar.Font = Properties.Settings.Default.fuente_letra;
            btnAceptar.Font = Properties.Settings.Default.fuente_letra;
            btnCancelar.Font = Properties.Settings.Default.fuente_letra;
            btnLimpiar.Font = Properties.Settings.Default.fuente_letra;

            txbNombre.ForeColor = Properties.Settings.Default.color_fuente;
            lblNombre.ForeColor = Properties.Settings.Default.color_fuente;
            lblUnidad.ForeColor = Properties.Settings.Default.color_fuente;
            txbUnidad.ForeColor = Properties.Settings.Default.color_fuente;
            btnExplorar.ForeColor = Properties.Settings.Default.color_fuente;
            btnAceptar.ForeColor = Properties.Settings.Default.color_fuente;
            btnCancelar.ForeColor = Properties.Settings.Default.color_fuente;
            btnLimpiar.ForeColor = Properties.Settings.Default.color_fuente;
        }
    }
}
