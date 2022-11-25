using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecepcionBodega
{
    // Formulario realizado por Juan
    public partial class FormVerProductos : Form
    {
        MySqlConnection dbconn = null;
        
        public FormVerProductos()
        {
            InitializeComponent();
            dbconn = new MySqlConnection(Properties.Settings.Default.dbconnection);
        }

        private void FormVerProductos_Load(object sender, EventArgs e)
        {
            cargarProductos();
            lblNombre.Text = "";
            lblStockUnidad.Text = "";
            LoadStyle();
        }

        private void cargarProductos()
        {
            try
            {
                dbconn.Open();
                string consulta = "select id_producto, nombre, unidad, stock, imagen from producto";
                MySqlCommand cmd = new MySqlCommand(consulta, dbconn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvTabla.DataSource = dt;
                dgvTabla.Columns["id_producto"].Visible = false;
                dgvTabla.Columns["unidad"].Visible = false;
                dgvTabla.Columns["stock"].Visible = false;
                dgvTabla.Columns["imagen"].Visible = false;

            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error con la base de datos " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error inesperado " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbconn.Close();
            }
        }

        private void dgvTabla_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvTabla.CurrentRow != null)
            {
                lblNombre.Text = dgvTabla.CurrentRow.Cells["nombre"].Value.ToString();
                lblStockUnidad.Text = dgvTabla.CurrentRow.Cells["stock"].Value.ToString() + " " + dgvTabla.CurrentRow.Cells["unidad"].Value.ToString();

                try
                {
                    byte[] img = (byte[])dgvTabla.CurrentRow.Cells["imagen"].Value;
                    MemoryStream ms = new MemoryStream(img);
                    ptbImgProducto.Image = Image.FromStream(ms);

                }
                catch (Exception ex)
                {
                    string dir = Path.GetDirectoryName(Application.ExecutablePath);
                    string filename = Path.Combine(dir, @"..\..\img\nofotos.png");
                    Image imgReturn = Image.FromFile(filename);
                    ptbImgProducto.Image = imgReturn;
                }
            }
        }

        // Funcion reutilizada del formulario principal realizada por Antonio
        private void LoadStyle()
        {
            splitContainer1.Panel1.BackColor = Properties.Settings.Default.color_menu;

            /*
            btnAnnadirEntrada.BackColor = Properties.Settings.Default.color_menu;
            btnAnnadirEntrada.ForeColor = Properties.Settings.Default.color_fuente_menu;
            btnAnnadirEntrada.Font = Properties.Settings.Default.fuente_letra;

            btnAnnadirSalida.BackColor = Properties.Settings.Default.color_menu;
            btnAnnadirSalida.ForeColor = Properties.Settings.Default.color_fuente_menu;
            btnAnnadirSalida.Font = Properties.Settings.Default.fuente_letra;

            btnAnnadirProducto.BackColor = Properties.Settings.Default.color_menu;
            btnAnnadirProducto.ForeColor = Properties.Settings.Default.color_fuente_menu;
            btnAnnadirProducto.Font = Properties.Settings.Default.fuente_letra;

            btnVerProductos.BackColor = Properties.Settings.Default.color_menu;
            btnVerProductos.ForeColor = Properties.Settings.Default.color_fuente_menu;
            btnVerProductos.Font = Properties.Settings.Default.fuente_letra;
            */
        }
    }
}
