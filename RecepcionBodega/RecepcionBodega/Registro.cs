using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecepcionBodega { 



    internal class Registro
    {

        private string idProducto; //comun
        private string nombreProducto;
        private DateTime fechaTramite; //comun
        private String lote; //comun
        private String albaran;
        private String proveedor; 
        private DateTime fechaCaducidad; //comun
        private int cantidad; //comun
        private String destino;
        private String obsevaciones;

        // Constructor entradas
        public Registro(string idProducto, string nombre, DateTime fechaTramite, String lote, String albaran, String proveedor, DateTime fechaCaducidad, int cantidad)
        {
            this.idProducto = idProducto;
            this.nombreProducto = nombre;   
            this.fechaTramite = fechaTramite;
            this.lote = lote;
            this.albaran = albaran;
            this.proveedor = proveedor;
            this.fechaCaducidad = fechaCaducidad;
            this.cantidad = cantidad;
            this.destino = "";
            this.obsevaciones = "";
        }

        // Constructor salidas
        public Registro(string idProducto, string nombreProducto, DateTime fechaTramite, String lote, int cantidad, String destino, String observaciones)
        {
            this.idProducto = idProducto;
            this.nombreProducto = nombreProducto;   
            this.fechaTramite = fechaTramite;
            this.lote = lote;
            this.albaran = "";
            this.proveedor = "";
            this.fechaCaducidad = DateTime.Now;
            this.cantidad = cantidad;
            this.destino = destino;
            this.obsevaciones = observaciones;
        }

        public string IdProducto { get => idProducto; set => idProducto = value; }
        public DateTime FechaTramite { get => fechaTramite; set => fechaTramite = value; }
        public string Lote { get => lote; set => lote = value; }
        public string Albaran { get => albaran; set => albaran = value; }
        public string Proveedor { get => proveedor; set => proveedor = value; }
        public DateTime FechaCaducidad { get => fechaCaducidad; set => fechaCaducidad = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public string Destino { get => destino; set => destino = value; }
        public string Obsevaciones { get => obsevaciones; set => obsevaciones = value; }
    }
}
