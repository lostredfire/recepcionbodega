using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

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
        /*
         * Este metodo se encarga de llamar a los metodos que hacen que funcione la aplicacion, tambien establece el valor por defecto de algunos componentes
         * 
         * Metodo realizado por Alvaro
         */
        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            CargarTablaEntradas();
            CargarCombo();
            lblTitulo.Text = "Entradas de Productos Enológicos";
            dtpDesde.Value = new DateTime(2022, 9, 1);
            dtpHasta.Value = DateTime.Now;
        }
        /*
         * Este metodo se encarga de cargar el estilo a la aplicacion
         * 
         * Realizado por Antonio
         */
        private void LoadStyle()
        {
            // Contenedores
            splitContainer1.Panel1.BackColor = Properties.Settings.Default.color_menu;
            splitContainer1.Panel2.BackColor = Properties.Settings.Default.color_ventana;

            // Botones menu
            btnAnnadirEntrada.BackColor = Properties.Settings.Default.color_ventana;
            btnAnnadirSalida.BackColor = Properties.Settings.Default.color_ventana;
            btnAnnadirProducto.BackColor = Properties.Settings.Default.color_ventana;
            btnVerProductos.BackColor = Properties.Settings.Default.color_ventana;
            btnSalir.BackColor = Properties.Settings.Default.color_ventana;

            btnAnnadirEntrada.ForeColor = Properties.Settings.Default.color_fuente;
            btnAnnadirSalida.ForeColor = Properties.Settings.Default.color_fuente;
            btnAnnadirProducto.ForeColor = Properties.Settings.Default.color_fuente;
            btnVerProductos.ForeColor = Properties.Settings.Default.color_fuente;
            btnSalir.ForeColor = Properties.Settings.Default.color_fuente;

            btnAnnadirEntrada.Font = Properties.Settings.Default.fuente_letra;
            btnAnnadirSalida.Font = Properties.Settings.Default.fuente_letra;
            btnAnnadirProducto.Font = Properties.Settings.Default.fuente_letra;
            btnVerProductos.Font = Properties.Settings.Default.fuente_letra;
            btnSalir.Font = Properties.Settings.Default.fuente_letra;

            // Tabla principal
            dgvTabla.Font = Properties.Settings.Default.fuente_letra;
            dgvTabla.ForeColor = Properties.Settings.Default.color_fuente;

            // Labels
            lblTitulo.ForeColor = Properties.Settings.Default.color_fuente;
            lblFiltros.ForeColor = Properties.Settings.Default.color_fuente;
            lblProducto.ForeColor = Properties.Settings.Default.color_fuente;
            lblDesde.ForeColor = Properties.Settings.Default.color_fuente;
            lblHasta.ForeColor = Properties.Settings.Default.color_fuente;
            lblLote.ForeColor = Properties.Settings.Default.color_fuente;

            lblTitulo.Font = Properties.Settings.Default.fuente_letra;
            lblFiltros.Font = Properties.Settings.Default.fuente_letra;
            lblProducto.Font = Properties.Settings.Default.fuente_letra;
            lblDesde.Font = Properties.Settings.Default.fuente_letra;
            lblHasta.Font = Properties.Settings.Default.fuente_letra;
            lblLote.Font = Properties.Settings.Default.fuente_letra;

            // Campos de entrada
            cmbProducto.ForeColor = Properties.Settings.Default.color_fuente;
            dtpDesde.CalendarForeColor = Properties.Settings.Default.color_fuente;

            // Botones de filtrado
            btnFiltrar.ForeColor = Properties.Settings.Default.color_fuente;
            btnLimpiar.ForeColor = Properties.Settings.Default.color_fuente;

            btnFiltrar.Font = Properties.Settings.Default.fuente_letra;
            btnLimpiar.Font = Properties.Settings.Default.fuente_letra;

        }


        /*
         * El método cargarTablaEntradas se encarga de cargar los registros de entradas y de salidas en el DataGridView nada mas se ejecute la aplicacion
         * Por defecto va a cargar primero las entradas
         * 
         * Método realizado por Álvaro
         * Consulta realizada por Antonio
         * 
         */


        private void CargarTablaEntradas()
        {
            try
            {
                dbconn.Open();
                string consulta = "SELECT * " +
                                    "FROM (SELECT e.id_producto AS id_producto, p.nombre AS producto, e.fecha_entrada AS fecha_tramite, e.lote AS lote, e.albaran AS albaran, e.proveedor AS proveedor, e.fecha_caducidad AS fecha_caducidad, e.cantidad AS cantidad, '' AS destino, '' AS observaciones " +
                                            "FROM producto_entrada e, producto p WHERE e.id_producto = p.id_producto " +
                                            "UNION " +
                                            "SELECT s.id_producto AS id_producto, p.nombre AS producto, s.fecha_salida AS fecha_tramite, s.lote AS lote, '' AS albaran, '' AS proveedor, null AS fecha_caducidad, s.cantidad AS cantidad, s.destino AS destino, s.observaciones AS observaciones " +
                                            "FROM producto_salida s, producto p WHERE s.id_producto = p.id_producto) AS t " +
                                    "ORDER BY fecha_tramite DESC";
                MySqlCommand cmd = new MySqlCommand(consulta, dbconn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvTabla.DataSource = dt;
                
                
                dgvTabla.Columns["id_producto"].Visible = false;

                ColorearFilas();



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
        /*
         * Este metodo se encarga de colorear de distinto color las filas de la tabla segun sean salidas o entradas
         * 
         * Método realizado por Álvaro
         * 
         */
        private void ColorearFilas()
        {
            try
            {
                foreach (DataGridViewRow row in dgvTabla.Rows)
                {
                    if (row.Cells["destino"].Value.ToString() == "")
                    {
                        row.DefaultCellStyle.BackColor = Color.LightGreen;
                    }
                    else
                    {
                        row.DefaultCellStyle.BackColor = Color.LightSalmon;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error inesperado\n" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

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
                cmbProducto.SelectedIndex = 0;
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
            //Silvia
            FormAñadirEntrada formañadirentrada = new FormAñadirEntrada();
            formañadirentrada.ShowDialog();
        }

        private void btnAnnadirSalida_Click(object sender, EventArgs e)
        {
            //Silvia
            FormAñadirSalida formañadirsalida = new FormAñadirSalida();
            formañadirsalida.ShowDialog();
        }

        /*
         * Este metodo se encarga de cargar la ventana de Añadir productos
         * 
         * Realizado por Antonio
         */
        private void btnAnnadirProducto_Click(object sender, EventArgs e)
        {
            FormAñadirProductos formAnnadirProductos = new FormAñadirProductos();
            formAnnadirProductos.ShowDialog();
        }

        /*
         * Este metodo se encarga de cargar la ventana de Ver productos
         * 
         * Realizado por Antonio
         */
        private void btnVerProductos_Click(object sender, EventArgs e)
        {
            FormVerProductos formVerProductos = new FormVerProductos();
            formVerProductos.ShowDialog();
        }

        /**
         * Este metodo se encarga de cerrar la aplicación
         * 
         * Método creado por Antonio
         */
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        

        /*
         * Este metodo se encarga de llamar al metodo filtrarTabla()
         * 
         * Metodo realizado por Alvaro
         */
        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            Type t = cmbProducto.SelectedItem.GetType();
            PropertyInfo prop = t.GetProperty("id_producto");
            String idProducto = prop.GetValue(cmbProducto.SelectedItem).ToString();
            String fechaHasta = dtpHasta.Value.AddDays(1).ToString("yyyy-MM-dd");
            filtrarTabla(idProducto, dtpDesde.Value.ToString("yyyy-MM-dd"), fechaHasta, txbLote.Text);  
        }


        /*
         * Este metodo se encarga de filtrar la tabla segun los filtros que marquemos
         * 
         * Metodo realizado por Alvaro
         * Modificado por Antonio
         * Consulta realizada por Antonio
         * 
         */
        private void filtrarTabla(string producto, string fechaDesde, string fechaHasta, string lote)
        {
            try
            {
                dbconn.Open();

                string consulta = "SELECT * " +
                                    "FROM (SELECT e.id_producto AS id_producto, p.nombre AS producto, e.fecha_entrada AS fecha_tramite, e.lote AS lote, e.albaran AS albaran, e.proveedor AS proveedor, e.fecha_caducidad AS fecha_caducidad, e.cantidad AS cantidad, '' AS destino, '' AS observaciones " +
                                            "FROM producto_entrada e, producto p WHERE e.id_producto = p.id_producto " +
                                            "UNION " +
                                            "SELECT s.id_producto AS id_producto, p.nombre AS producto, s.fecha_salida AS fecha_tramite, s.lote AS lote, '' AS albaran, '' AS proveedor, null AS fecha_caducidad, s.cantidad AS cantidad, s.destino AS destino, s.observaciones AS observaciones " +
                                            "FROM producto_salida s, producto p WHERE s.id_producto = p.id_producto) AS t " +
                                    "WHERE";

                if (producto.Equals("0"))
                {
                    consulta += " fecha_tramite >= '" + fechaDesde + "' and fecha_tramite < '" + fechaHasta + "'";
                    if (!lote.Equals(""))
                    {
                        consulta += " and lote = '" + lote + "'";

                        MySqlCommand cmd = new MySqlCommand(consulta, dbconn);
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvTabla.DataSource = dt;
                        if(dt.Rows.Count == 0)
                        {
                            MessageBox.Show("El lote que has introducido está mal o no existe", "¡Cuidado!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                            
                        dgvTabla.Columns["id_producto"].Visible = false;
                    }
                    else
                    {
                        MySqlCommand cmd = new MySqlCommand(consulta, dbconn);
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvTabla.DataSource = dt;

                            
                        dgvTabla.Columns["id_producto"].Visible = false;
                    }
                }
                else
                {
                    consulta += " id_producto = " + producto;
                    consulta += " and fecha_tramite >= '" + fechaDesde + "' and fecha_tramite < '" + fechaHasta +"'";

                    if (!lote.Equals(""))
                        consulta += " and lote = '" + lote + "'";

                    consulta += " ORDER BY fecha_tramite DESC";

                    MySqlCommand cmd = new MySqlCommand(consulta, dbconn);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvTabla.DataSource = dt;
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("El lote que has introducido está mal o no existe", "¡Cuidado!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    dgvTabla.Columns["id_producto"].Visible = false;
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
                ColorearFilas();
            }
        }

        /*
         * Este metodo se encarga de colorear las filas cada vez que se ordena la tabla
         * 
         * Metodo realizado por alvaro
         */
        private void dgvTabla_Sorted(object sender, EventArgs e)
        {
            ColorearFilas();
        }

        /*
         * Este metodo restablece el valor por defecto de todos los filtros
         * 
         * Metodo realizado por alvaro
         */
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cmbProducto.SelectedIndex = 0;
            dtpDesde.Value = new DateTime(2022, 9, 1);
            dtpHasta.Value = DateTime.Now;
            txbLote.Text = "";

        }
    }
}
