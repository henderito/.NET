using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_Henderson
{
    public class Deposito
    {
        public int id { get; set; }
        public string proposito { get; set; }
        public List<Pasillo> pasillos { get; set; }
        public List<Cliente> clientes { get; set; }
        public Dueño dueño { get; set; }
        public Administracion administracion { get; set; }

        public int calcularCantidadPasillos() { return pasillos.Count(); }

        public int calcularClientes() { return clientes.Count(); }

        public int calcularCompartimientosOcupados()
        {
            int total = 0;
            foreach (Pasillo p in pasillos)
            {
                foreach (Compartimiento c in p.compartimientos)
                { if (c.solicitante != null) { total++; } }
            }
            return total;
        }

        public double calcularIngresoMensual()
            {double total = 0;
             foreach (Pasillo p in pasillos)
                { total = total + p.calcularIngresoMensual(); }
            return total;
        }

        public Deposito() { }

        public Deposito(int id, string p, List<Pasillo>pas, List<Cliente>c, Dueño d, Administracion a)
            {this.id = id;
            proposito = p;
            pasillos = pas;
            clientes = c;
            dueño = d;
            administracion = a;}
    }
}
