using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RecepcionBodega
{
    public partial class FormAñadirEntrada : Form
    {
        // Interfaz gráfica realizada por Silvia.
        int temp = 0;
        MySqlConnection dbconn = null;
        public FormAñadirEntrada()
        {
            InitializeComponent();
            ElementosParametrizados();
            dbconn = new MySqlConnection(Properties.Settings.Default.dbconnection);
        }
 
        private void FormAñadirEntrada_Load(object sender, EventArgs e)
        {
           
            CargarComboProducto();
            cmbProducto.SelectedIndexChanged += cmbProducto_SelectedIndexChanged;
            CargarFechaActual();
        }
        /** Metodo CargarFormatoCantidad, obtiene de la base de datos el tipo de cantidad seleccionada
         *  para el tipo de producto y marcarlo en el checkbox.
         *  Metodo realizado por Silvia.
         */

        public void CargarFormatoCantidad()
        {
            string unidad = "";
            string producto = "";
            
            
            try
            {   
                Type t = cmbProducto.SelectedItem.GetType();
                PropertyInfo prop = t.GetProperty("id_producto");
                producto = prop.GetValue(cmbProducto.SelectedItem).ToString();

                if(dbconn.State != ConnectionState.Open)
                {
                    dbconn.Open();
                }
                string consulta = "select unidad from producto where id_producto = "+ producto;
                MySqlCommand cmd = new MySqlCommand(consulta, dbconn);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                if (dataReader.Read())
                {
                    unidad = dataReader["unidad"].ToString();
                }
                
                dataReader.Close();

                lblUnidad.Text = unidad;
                
                      
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error con la base de datos \n" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dbconn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error inesperado \n" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dbconn.Close();
            }
           
             dbconn.Close();
            

        }

        /** Metodo CargarComboProducto(), obtiene de la base de datos los productos 
         *  y los id, y los muestra en el comboBox
         *  Metodo realizado por Silvia.
         */
        private void CargarComboProducto()
        {
            try
            {
                dbconn.Open();
                string consulta = "select id_producto, nombre from producto";
                MySqlCommand cmd = new MySqlCommand(consulta, dbconn);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                cmbProducto.Items.Add(new
                {
                    id_producto = -1,
                    nombre = "Seleccione un producto..."
                }) ;

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
                
                dataReader.Close();
                cmbProducto.SelectedIndex = 0;
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error con la base de datos\n" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dbconn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error inesperado\n" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dbconn.Close();
            }
            dbconn.Close();
        }
        /** Metodo AñadirStock, se usa para obtener la cantidad del producto y se añade al stock (tabla
         *  producto) para poder tener el total de la cantidad del producto disponible 
         *  Metodo realizado por Silvia.
         */
        public void AñadirStock()
        {
            float cantidad = float.Parse(txbCantidad.Text);
            string producto = "";

            try
            {
                Type t = cmbProducto.SelectedItem.GetType();
                PropertyInfo prop = t.GetProperty("id_producto");
                producto = prop.GetValue(cmbProducto.SelectedItem).ToString();

                if (dbconn.State != ConnectionState.Open)
                {
                    dbconn.Open();
                }
                string consulta = "UPDATE producto SET stock = stock +" + cantidad + " WHERE id_producto =" + producto;
                MySqlCommand cmd = new MySqlCommand(consulta, dbconn);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                dataReader.Close();
               

            }
            catch (MySqlException e)
            {
                if (txbCantidad.Text.Contains(","))
                {
                    MessageBox.Show("El decimal debe introducise con un '.'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Error con la base de datos \n" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
                dbconn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error inesperado \n" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dbconn.Close();
            }

            dbconn.Close();
        }



        /** Metodo ComprobarFormulario, se usa para comprobar que todos los elementos introducidos
         * en el formulario tengan el formato correcto, todos los elementos seleccionados y no falte 
         * ningún dato por introduccir antes de ser enviado a la base de datos.
         * 
         *  Metodo realizado por Silvia.
         */
        public void ComprobarFormulario()
        {
            // Comprobando cmbProducto
            if (cmbProducto.SelectedIndex == 0 || txbAlbaran.Text == "" || txbLote.Text == "" || txbCantidad.Text == "" || txbProveedor.Text == "")
            {
                MessageBox.Show("Falta de datos, porfavor rellene todos los elementos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if(!float.TryParse(txbCantidad.Text, out float temp)){
                MessageBox.Show("Datos erroneos, porfavor introduce una cadena de numeros (Cantidad, Decimales usando '.' ).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            else {
                try
                {
                    InsertarFormulario();
                    MessageBox.Show("Registros introducidos correctamente.", "Inserción Entrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AñadirStock();
                    btnAceptar.DialogResult = DialogResult.OK;
                    Limpiar();
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al introducir los registros en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }

        }
        /** Metodo InsertarFormulario, Hace una conexion con la base de datos, captura los elementos introducidos
         * y los intruduce a la base de datos.
         * 
         *  Metodo realizado por Silvia.
         */
        public void InsertarFormulario()
        {
            dtpFechaCaducidad.Format = DateTimePickerFormat.Custom;
            dtpFechaEntrada.Format = DateTimePickerFormat.Custom;
            dtpFechaEntrada.CustomFormat = "yyyy-MM-dd H:mm:ss";
            dtpFechaCaducidad.CustomFormat = "yyyy-MM-dd";

            Type t = cmbProducto.SelectedItem.GetType();
            PropertyInfo prop = t.GetProperty("id_producto");
            String producto = prop.GetValue(cmbProducto.SelectedItem).ToString();

            // Annadimos en una tabla nueva Registro, los resultados obtenidos 
            dbconn.Open();
            string query = "INSERT INTO producto_entrada (id_producto_entrada,id_producto,fecha_entrada,lote,albaran,proveedor,fecha_caducidad,cantidad) VALUES( NULL , '" + producto + "' , '" + dtpFechaEntrada.Text + "' , '" + txbLote.Text + "' , '" + txbAlbaran.Text + "' , '" + txbProveedor.Text + "' , '" + dtpFechaCaducidad.Text + "' , " + float.Parse(txbCantidad.Text) + ")";
            MySqlCommand commandDatabase = new MySqlCommand(query, dbconn);
            commandDatabase.ExecuteNonQuery();
            dbconn.Close();
        }

        /** El metodo cargarFechaActual, estable el valor de los datatiempickers a la fecha
         * actual del sistema.
         * 
         *  Metodo realizado por Silvia.
         */
        private void CargarFechaActual() {
            dtpFechaEntrada.Value = DateTime.Now;
            dtpFechaCaducidad.Value = DateTime.Now;
        }


        /** Las propiedades referentes a el tipo de fuente, tamaño de fuente, color de fuente
         *  color de la ventana del menu y color de la ventana principal son parametizables.
         *  
         *  Metodo realizado por Silvia.
         */
        private void ElementosParametrizados()
        {
            // Fuente de letra
            btnAceptar.Font = Properties.Settings.Default.fuente_letra;
            btnCancelar.Font = Properties.Settings.Default.fuente_letra;
            btnLimpiar.Font = Properties.Settings.Default.fuente_letra;

            label1.Font = Properties.Settings.Default.fuente_letra;
            label2.Font = Properties.Settings.Default.fuente_letra;
            label3.Font = Properties.Settings.Default.fuente_letra;
            label4.Font = Properties.Settings.Default.fuente_letra;
            label5.Font = Properties.Settings.Default.fuente_letra;
            label6.Font = Properties.Settings.Default.fuente_letra;
            label7.Font = Properties.Settings.Default.fuente_letra;

            cmbProducto.Font = Properties.Settings.Default.fuente_letra;
            dtpFechaEntrada.Font = Properties.Settings.Default.fuente_letra;
            dtpFechaCaducidad.Font = Properties.Settings.Default.fuente_letra;
            txbCantidad.Font = Properties.Settings.Default.fuente_letra;
            txbAlbaran.Font = Properties.Settings.Default.fuente_letra;
            txbProveedor.Font = Properties.Settings.Default.fuente_letra;
            txbLote.Font = Properties.Settings.Default.fuente_letra;
            lblUnidad.Font = Properties.Settings.Default.fuente_letra;
            
            

            // Color de la fuente de letra
            btnAceptar.ForeColor = Properties.Settings.Default.color_fuente;
            btnCancelar.ForeColor = Properties.Settings.Default.color_fuente;
            btnLimpiar.ForeColor = Properties.Settings.Default.color_fuente;

            label1.ForeColor = Properties.Settings.Default.color_fuente;
            label2.ForeColor = Properties.Settings.Default.color_fuente;
            label3.ForeColor = Properties.Settings.Default.color_fuente;
            label4.ForeColor = Properties.Settings.Default.color_fuente;
            label5.ForeColor = Properties.Settings.Default.color_fuente;
            label6.ForeColor = Properties.Settings.Default.color_fuente;
            label7.ForeColor = Properties.Settings.Default.color_fuente;

            cmbProducto.ForeColor = Properties.Settings.Default.color_fuente;
            dtpFechaEntrada.ForeColor = Properties.Settings.Default.color_fuente;
            dtpFechaCaducidad.ForeColor = Properties.Settings.Default.color_fuente;
            txbCantidad.ForeColor = Properties.Settings.Default.color_fuente;
            txbAlbaran.ForeColor = Properties.Settings.Default.color_fuente;
            txbProveedor.ForeColor = Properties.Settings.Default.color_fuente;
            txbLote.ForeColor = Properties.Settings.Default.color_fuente;
            lblUnidad.ForeColor = Properties.Settings.Default.color_fuente;
            


            // Color ventana
            splitContainer1.Panel2.BackColor = Properties.Settings.Default.color_ventana;

            // Color del menu
            splitContainer1.Panel1.BackColor = Properties.Settings.Default.color_menu;

        }
         /** El metodo Limpiar, establece los valores a sus valores iniciales
         * 
         *  Metodo realizado por Silvia.
         */
         private void Limpiar()
        {
            cmbProducto.SelectedIndex = 0;
            CargarFechaActual();
            txbAlbaran.Text = "";
            txbLote.Text = "";
            txbCantidad.Text = "";
            txbProveedor.Text = "";
            lblUnidad.Text = "";

        }
        
        /** El botón Limpiar, al ser pulsado establece el formulario a sus valores inciales 
         * en este caso vacio y para los datatimepickers a la fecha actual.
         * 
         *  Metodo realizado por Silvia.
         */
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ComprobarFormulario();
        }

        private void cmbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarFormatoCantidad();
        }
    }
}
