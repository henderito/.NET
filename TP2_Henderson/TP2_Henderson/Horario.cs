using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_Henderson
{
    public class Horario
        {public string turno { get; set; }
        public DateTime hEntrada { get; set; }
        public DateTime hSalida { get; set; }

         public int calcularHorasDiarias()
             { return (hSalida.Hour - hEntrada.Hour); }

        public Horario() { }

        public Horario(string t, DateTime hE, DateTime hS)
            {turno = t;
            hEntrada = hE;
            hSalida = hS;}
    }
}
