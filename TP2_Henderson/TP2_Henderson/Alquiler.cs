using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_Henderson
{
    public class Alquiler
        {public DateTime vencimiento { get; set; }
        public DateTime inicio { get; set; }
        public double precioMensual { get; set; }
        public double recargoPorAtrazoEnPago { get; set; }
        public double pagoAcumulado { get; set; }

        public double calcularDiasRestantesDeAlquiler()
            {return (vencimiento - DateTime.Today.Date).TotalDays;}

        public double calcularSaldoTotal()
             {return ((vencimiento - inicio).TotalDays * (precioMensual/30)); }

        public Alquiler() { }

        public Alquiler(DateTime v, DateTime i, double pM, double rA, double pA)
            {vencimiento = v;
            inicio = i;
            precioMensual = pM;
            recargoPorAtrazoEnPago = rA;
            pagoAcumulado = pA;}
    }
}
