using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_Henderson
{
    public class Empleado : Persona
        {public Horario horario { get; set; }
        public Jerarquia puesto { get; set; }
        public Administracion administracion { get; set; }

        public Empleado() { }

        public Empleado(Horario h, Jerarquia p, Administracion admin, int d, string n, string a, DateTime f, string s, string nac)
            {this.horario = h;
            this.puesto = p;
            this.administracion = admin;
            base.DNI = d;
            base.nombre = n;
            base.apellido = a;
            base.fechaNac = f;
            base.sexo = s;
            base.nacionalidad = nac;}

        public float calcularSueldo()
            { return (puesto.sueldoBase * horario.calcularHorasDiarias()); }
  
    }
}
