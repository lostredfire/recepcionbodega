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
    public partial class FormPrincipal : Form
    {
        /*
         * Diseño de la pantalla principal realizado por Antonio
         * Modificacion en el diseño, realizado por Alvaro
         */
        MySqlConnection dbconn = null;
        public FormPrincipal()
        {
            InitializeComponent();
            LoadStyle();
            dbconn = new MySqlConnection(Properties.Settings.Default.dbconnection);
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            CargarTablaEntradas();
            lblTitulo.Text = "Entradas de Productos Enológicos";
        }
        /*
         * Este metodo se encarga de cargar el estilo a la aplicacion
         * 
         * Realizado por Antonio
         * Modificado por Alvaro
         */
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
        /*
         * El método cargarTablaEntradas se encarga de cargar los registros de entradas en el DataGridView nada mas se ejecute la aplicacion
         * Por defecto va a cargar primero las entradas
         * 
         * Método realizado por Álvaro
         * 
         */
        private void CargarTablaEntradas()
        {
            try
            {
                dbconn.Open();
                string consulta = "select id_producto_entrada, id_producto, fecha_entrada, lote, albaran, proveedor, fecha_caducidad, cantidad from producto_entrada";
                MySqlCommand cmd = new MySqlCommand(consulta, dbconn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvTabla.DataSource = dt;

                dgvTabla.Columns["id_producto_entrada"].Visible = false;
                dgvTabla.Columns["id_producto"].Visible = false;


            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error con la base de datos" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error inesperado" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbconn.Close();
            }
        }

        private void CargarTablaSalidas()
        {
            try
            {
                dbconn.Open();
                string consulta = "select id_producto_salida, id_producto, fecha_salida, lote, cantidad, destino, observaciones from producto_salida";
                MySqlCommand cmd = new MySqlCommand(consulta, dbconn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvTabla.DataSource = dt;

                dgvTabla.Columns["id_producto_salida"].Visible = false;
                dgvTabla.Columns["id_producto"].Visible = false;


            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error con la base de datos" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error inesperado" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbconn.Close();
            }
        }

        private void CargarCombo()
        {

        }

        private void btnAnnadirEntrada_Click(object sender, EventArgs e)
        {

        }

        private void btnAnnadirSalida_Click(object sender, EventArgs e)
        {

        }

        private void btnAnnadirProducto_Click(object sender, EventArgs e)
        {

        }

        private void btnVerProductos_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

        }
        /*
         * Este metodo se encarga de cargar el datagridview con las entradas cuando su radiobutton esta checked
         * 
         * Método realizado por Álvaro
         * 
         */
        private void rbEntradas_CheckedChanged(object sender, EventArgs e)
        {
            CargarTablaEntradas();
            lblTitulo.Text = "Entradas de Productos Enológicos";
        }

        /*
         * Este metodo se encarga de cargar el datagridview con las salidas cuando su radiobutton esta checked
         * 
         * Método realizado por Álvaro
         * 
         */
        private void rbSalidas_CheckedChanged(object sender, EventArgs e)
        {
            CargarTablaSalidas();
            lblTitulo.Text = "Salidas de Productos Enológicos";
        }

        
    }
}
