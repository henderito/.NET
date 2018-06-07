using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_Henderson
{
    public class Compartimiento
        {public int id { get; set; }
        public Cliente solicitante { get; set; }
        public Alquiler detalle { get; set; }
        public Producto productoAdministrado { get; set; }
        public int medidaM2 { get; set; }

        public Compartimiento() { }

         public Compartimiento(int id)
             {this.id = id;
              solicitante = null;}

         public Compartimiento(int id,Cliente c, Alquiler a, Producto p, int m)
             {this.id = id;
              this.solicitante = c;
              this.detalle = a;
              this.productoAdministrado = p;
              this.medidaM2 = m;}

         public int calcularNumeroDeProductos()
             { return (medidaM2 / productoAdministrado.medidaM2); }
    }
}
