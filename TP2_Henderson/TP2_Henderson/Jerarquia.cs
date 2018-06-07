using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_Henderson
{
    public class Jerarquia
        {public string puesto { get; set; }
        public float sueldoBase { get; set; }
        public DateTime fechaEntradaEmpresa { get; set; }
        public float bonoPorAntiguedad { get; set; }

         public int calcularAntiguedad()
            {int añosSeguros = DateTime.Today.Year - (fechaEntradaEmpresa.Year + 1);
             int mesActual = DateTime.Today.Month;
             if (mesActual > 9) { mesActual = mesActual - 12; }  //Acomodo los meses para la comparacion del mes de entrada
             if (mesActual + 3 <= fechaEntradaEmpresa.Month) { añosSeguros++; }
             return añosSeguros;}

         public float calcularBono()
             {return (sueldoBase * (calcularAntiguedad()/100)); }

        public Jerarquia() { }

        public Jerarquia(string p, float sB, DateTime fE, float bPA)
            {puesto = p;
            sueldoBase = sB;
            fechaEntradaEmpresa = fE;
            bonoPorAntiguedad = bPA;}
    }
}
