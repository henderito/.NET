using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_Henderson
{
    public class Administracion
        {public int id { get; set; }
         public List<Empleado> empleados { get; set; }
         public List<Deposito> depositos { get; set; }

        public Administracion() { }

        public Administracion(int id, List<Empleado>e,List<Deposito>d)
            {this.id = id;
            empleados = e;
            depositos = d;}
    }
}
