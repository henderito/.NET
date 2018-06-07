using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_Henderson
{
    public abstract class Persona
        {public int DNI { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public DateTime fechaNac { get; set; }
        public string sexo { get; set; }
        public string nacionalidad { get; set; }

         public int calcularEdad()
             {if ((fechaNac.Month < DateTime.Today.Month) || ((fechaNac.Month == DateTime.Today.Month) && (fechaNac.Day < DateTime.Today.Day)))
                 { return (DateTime.Today.Year - fechaNac.Year)+1; }
             return (DateTime.Today.Year - fechaNac.Year); }

    }
}
