using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_Henderson
{
    public class Dueño : Persona
        {public List<Deposito> depositos { get; set; }

        public Dueño() { }

        public Dueño(List<Deposito> depos, int d, string n, string a, DateTime f, string s, string nac)
            {depositos = depos;
            base.DNI = d;
            base.nombre = n;
            base.apellido = a;
            base.fechaNac = f;
            base.sexo = s;
            base.nacionalidad = nac;}

        public double calcularGananciaMensual()
            {double total = 0;
            foreach (Deposito d in depositos)
                { total = total + d.calcularIngresoMensual(); }
            return total;}


    }
}
