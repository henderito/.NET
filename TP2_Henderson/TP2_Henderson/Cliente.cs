using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_Henderson
{
    public class Cliente : Persona
        {public List<Compartimiento> alquilados { get; set; }

        public Cliente() { }

        public Cliente(List<Compartimiento>alquilados, int d, string n, string a, DateTime f, string s, string nac)
            {this.alquilados = alquilados;
            base.DNI = d;
            base.nombre = n;
            base.apellido = a;
            base.fechaNac = f;
            base.sexo = s;
            base.nacionalidad = nac;}

        public double calcularSaldoPendienteTodos()
            {double aux = 0;
            foreach (Compartimiento c in alquilados)
                 { aux = aux +c.detalle.calcularSaldoTotal(); }
            return aux;}

        public double calcularSaldoCompartimiento(int idCompartimiento)
            {foreach (Compartimiento c in alquilados)
                {if (c.id == idCompartimiento) {return (c.detalle.calcularDiasRestantesDeAlquiler() * c.detalle.precioMensual);}}
            return 0;
        }

    }
}
