using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
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
            //CargarTablaEntradas();
            CargarCombo();
            lblTitulo.Text = "Entradas de Productos Enológicos";
            dtpDesde.Value = new DateTime(2022, 9, 1);
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

        private void CargarTablas()
        {

            try
            {

                var arrRegistros = new ArrayList();

                dbconn.Open();
                string consulta = "";
                MySqlCommand command = new MySqlCommand(consulta, dbconn);
                MySqlDataReader result = command.ExecuteReader();

                while (result.Read())
                {
                    Registro e = new Registro(idProducto, fechaTramite, lote, albaran, proveedor, fechaCaducidad, cantidad);
                    arrRegistros.Add(e);
                    //id_producto = dataReader["id_producto"].ToString(),
                }

            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error con la base de datos\n" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error inesperado\n" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbconn.Close();
            }

        }

        /*private void CargarTablaEntradas()
        {
            try
            {
                dbconn.Open();
                string consulta = "select e.id_producto_entrada, e.id_producto, p.nombre, e.fecha_entrada, e.lote, e.albaran, e.proveedor, e.fecha_caducidad, e.cantidad " +
                    "from producto_entrada e, producto p " +
                    "where e.id_producto = p.id_producto";
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
        }*/
        /*
         * El método cargarTablaEntradas se encarga de cargar los registros de salidas en el DataGridView nada mas se ejecute la aplicacion
         * 
         * Método realizado por Álvaro
         * 
         */
        /*private void CargarTablaSalidas()
        {
            try
            {
                dbconn.Open();
                string consulta = "select s.id_producto_salida, s.id_producto, p.nombre, s.fecha_salida, s.lote, s.cantidad, s.destino, s.observaciones " +
                    "from producto_salida s, producto p " +
                    "where s.id_producto = p.id_producto;";
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
                MessageBox.Show("Error con la base de datos\n" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error inesperado\n" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbconn.Close();
            }
        }*/

        /*
         * El metodo CargarCombo se encarga de cargar el el combobox con el nombre de los productos
         * Tambien tiene la opcion de <Todos>
         * 
         * Método realizado por Álvaro
         * 
         */
        private void CargarCombo()
        {
            try
            {
                dbconn.Open();
                string consulta = "select id_producto, nombre from producto";
                MySqlCommand cmd = new MySqlCommand(consulta, dbconn);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    cmbProducto.Items.Add(new
                    {
                        id_producto = dataReader["id_producto"].ToString(),
                        nombre = dataReader["nombre"].ToString()
                    });
                }
                cmbProducto.ValueMember = "id_producto";
                cmbProducto.DisplayMember = "nombre";

                cmbProducto.Items.Insert(0, new {id_producto = 0, nombre = "<Todos>"});

                dataReader.Close();
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error con la base de datos\n" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error inesperado\n" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbconn.Close();
            }
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

        
        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            filtrarTabla(cmbProducto.Text, dtpDesde.Value.ToString(), dtpHasta.Value.ToString(), txbLote.Text);
            
        }

        private void filtrarTabla(string producto, string fechaDesde, string fechaHasta, string lote)
        {
            try
            {
                dbconn.Open();
                if (rbEntradas.Checked)
                {
                    string consulta = "select e.id_producto_entrada, e.id_producto, p.nombre, e.fecha_entrada, e.lote, e.albaran, e.proveedor, e.fecha_caducidad, e.cantidad " +
                    "from producto_entrada e, producto p " +
                    "where e.id_producto = p.id_producto";
                    if (producto.Equals("<Todos>"))
                    {
                        consulta += " and e.fecha_entrada >= " + fechaDesde + " and e.fecha_entrada < " + fechaHasta;
                        if (!lote.Equals(""))
                        {
                            consulta += " and e.lote = " + lote;

                            MySqlCommand cmd = new MySqlCommand(consulta, dbconn);
                            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dgvTabla.DataSource = dt;

                            dgvTabla.Columns["id_producto_entrada"].Visible = false;
                            dgvTabla.Columns["id_producto"].Visible = false;
                        }
                        else
                        {
                            MySqlCommand cmd = new MySqlCommand(consulta, dbconn);
                            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dgvTabla.DataSource = dt;

                            dgvTabla.Columns["id_producto_entrada"].Visible = false;
                            dgvTabla.Columns["id_producto"].Visible = false;
                        }
                    }
                    else
                    {
                        consulta += " and e.id_producto = " + producto;
                        consulta += " and e.fecha_entrada >= " + fechaDesde + " and e.fecha_entrada < " + fechaHasta;

                        if (!lote.Equals(""))
                        {
                            consulta += " and e.lote = " + lote;

                            MySqlCommand cmd = new MySqlCommand(consulta, dbconn);
                            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dgvTabla.DataSource = dt;

                            dgvTabla.Columns["id_producto_entrada"].Visible = false;
                            dgvTabla.Columns["id_producto"].Visible = false;
                        }
                        else
                        {
                            MySqlCommand cmd = new MySqlCommand(consulta, dbconn);
                            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dgvTabla.DataSource = dt;

                            dgvTabla.Columns["id_producto_entrada"].Visible = false;
                            dgvTabla.Columns["id_producto"].Visible = false;
                        }
                    }
                }

                if (rbSalidas.Checked)
                {
                    string consulta = "select s.id_producto_salida, s.id_producto, p.nombre, s.fecha_salida, s.lote, s.cantidad, s.destino, s.observaciones " +
                    "from producto_salida s, producto p " +
                    "where s.id_producto = p.id_producto;";

                    if (producto.Equals("<Todos>"))
                    {
                        consulta += " and s.fecha_salida >= " + fechaDesde + " and s.fecha_salida < " + fechaHasta;
                        if (!lote.Equals(""))
                        {
                            consulta += " and s.lote = " + lote;

                            MySqlCommand cmd = new MySqlCommand(consulta, dbconn);
                            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dgvTabla.DataSource = dt;

                            dgvTabla.Columns["id_producto_salida"].Visible = false;
                            dgvTabla.Columns["id_producto"].Visible = false;
                        }
                        else
                        {
                            MySqlCommand cmd = new MySqlCommand(consulta, dbconn);
                            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dgvTabla.DataSource = dt;

                            dgvTabla.Columns["id_producto_salida"].Visible = false;
                            dgvTabla.Columns["id_producto"].Visible = false;
                        }
                    }
                    else
                    {
                        consulta += " and s.id_producto = " + producto;
                        consulta += " and s.fecha_salida >= " + fechaDesde + " and s.fecha_salida < " + fechaHasta;

                        if (!lote.Equals(""))
                        {
                            consulta += " and s.lote = " + lote;

                            MySqlCommand cmd = new MySqlCommand(consulta, dbconn);
                            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dgvTabla.DataSource = dt;

                            dgvTabla.Columns["id_producto_salida"].Visible = false;
                            dgvTabla.Columns["id_producto"].Visible = false;
                        }
                        else
                        {
                            MySqlCommand cmd = new MySqlCommand(consulta, dbconn);
                            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dgvTabla.DataSource = dt;

                            dgvTabla.Columns["id_producto_salida"].Visible = false;
                            dgvTabla.Columns["id_producto"].Visible = false;
                        }
                    }
                }
                
                
                


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
        
    }
}
