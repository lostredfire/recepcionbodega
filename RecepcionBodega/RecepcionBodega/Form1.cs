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
        public FormPrincipal()
        {
            InitializeComponent();
            loadStyle();
        }

        private void loadStyle()
        {
            btnAnnadirEntrada.BackColor = Properties.Settings.Default.color_menu;
            btnAnnadirEntrada.ForeColor = Properties.Settings.Default.color_fuente_menu;
            btnAnnadirEntrada.Font = Properties.Settings.Default.fuente_letra;
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
    }
}
