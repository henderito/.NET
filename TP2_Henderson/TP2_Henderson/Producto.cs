using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_Henderson
{
    public class Producto
        {public int id { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public double precio { get; set; }
         public int medidaM2 { get; set; }

        public Producto() { }

        public Producto(int id, string n, string d, double p, int m)
            {this.id = id;
            nombre = n;
            descripcion = d;
            precio = p;
            medidaM2 = m;
        }
    }
}
