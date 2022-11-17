using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecepcionBodega
{
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
    }
}
