using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_Henderson
{
    public class Pasillo
        {public int id { get; set; }
         public List<Compartimiento> compartimientos { get; set; }

        public int calcularCompartimientosOcupados()
            {int aux = 0;
             foreach (Compartimiento c in compartimientos)
                 {if (c.solicitante != null) {aux++;}}
             return aux;}

        public double calcularIngresoMensual()
            {double aux = 0;
             foreach (Compartimiento c in compartimientos)
                { if (c.solicitante != null) { aux = aux + c.detalle.precioMensual; } }
             return aux;
        }

        public Pasillo() { }

        public Pasillo(int id, List<Compartimiento> c)
            {this.id = id;
            compartimientos = c;}
    }
}
