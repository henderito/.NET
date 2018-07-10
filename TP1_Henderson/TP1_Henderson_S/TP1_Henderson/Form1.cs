using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace TP1_Henderson
{
    public partial class Form1 : Form
    {
        public List<string> colores = new List<string> { "Rojo", "Amarillo", "Azul", "Verde", "Negro", "Blanco", "Rosa" };
        public BindingList<string> objetosIzq = new BindingList<string>();
        public BindingList<string> objetosDer = new BindingList<string>();

        public Form1()
           {InitializeComponent();
            listDerecha.DataSource = objetosDer;
            listIzquierda.DataSource = objetosIzq;
            cmbColor.DataSource = colores;}

        //Funciones para lo relacionado a Carga de Persona

        private bool validarCamposCargaPersona()
            {if ((txtNombre.Text != "") && (txtApellido.Text != "") && (dtpFechaNac.Value.Date < DateTime.Today) && checkMusica())
                { return true; }
             return false;}

        private bool checkMusica()
            {int aux = 0;
             foreach (CheckBox chkBox in this.tabPersona.Controls.OfType<CheckBox>())
                 {if (chkBox.Checked)
                     {aux=aux+1; }}
             if (aux > 0)
                {return true;}
             return false;}

        protected void calcularEdad(System.Object sender, System.EventArgs e)
           {System.DateTime fechaNac = dtpFechaNac.Value.Date;
            int edad = DateTime.Today.Year - fechaNac.Year;
            if ((DateTime.Today.Month < fechaNac.Month) || ((DateTime.Today.Month == fechaNac.Month) && (DateTime.Today.Day <= fechaNac.Day)))
                { edad = edad + 1; }
            lblEdad.Text = "Edad: " + edad;}

        protected List<string> getGustosMusicales()
            {List<string> musica = new List<string>();
             foreach (CheckBox chkBox in this.tabPersona.Controls.OfType<CheckBox>())
                {if (chkBox.Checked)
                    {musica.Add(chkBox.Text);}}
             return musica;}
            
        protected void btnClickAceptar(System.Object sender, System.EventArgs e)
            {if (validarCamposCargaPersona())
                {List<string> musica = getGustosMusicales();
                 string msg = "Nombre: " + txtNombre.Text + "\n" + "Apellido: " + txtApellido.Text + "\n" + 
                                   lblEdad.Text + "\n" + "Gustos Musicales: ";
                musica.ForEach(delegate (string m)
                   {msg += m;
                    msg += "; ";});
                msg += ("\n" + "Color Favorito: " + cmbColor.Text);
                 MessageBox.Show(msg);}
                else
                    {if (DateTime.Today.Date <= dtpFechaNac.Value.Date)
                        { MessageBox.Show("La fecha de nacimiento no puede ser posterior al dia de hoy..."); }
                     else
                        { MessageBox.Show("Falta información por cargar..."); }}}

        //Funciones relacionadas a la Carga de Objetos

        protected void btnClickAgregarObjeto(System.Object sender, System.EventArgs e)
            {if (txtCarga.Text == "") {return; }
                if (validarPalabraEnLista(txtCarga.Text, objetosIzq))
                    {objetosIzq.Add(txtCarga.Text);}
                txtCarga.Text = "";}

        protected void btnPasarDeIzquierdaUno(System.Object sender, System.EventArgs e)
            {if (objetosIzq.Count == 0) { MessageBox.Show("No hay elementos en la lista"); }
             if ((objetosIzq.Count > 0) && validarPalabraEnLista(objetosIzq[listIzquierda.Items.IndexOf(listIzquierda.SelectedItem)], objetosDer))
                {objetosDer.Add(objetosIzq[listIzquierda.Items.IndexOf(listIzquierda.SelectedItem)]);
                 objetosIzq.Remove(listIzquierda.SelectedItem.ToString());}}

        protected void btnPasarDeIzquierdaMuchos(System.Object sender, System.EventArgs e)
            {if (objetosIzq.Count == 0)
                { MessageBox.Show("No hay elementos en la lista"); }
             for (int i = objetosIzq.Count -1; i>=0 ; i--)
                {if (validarPalabraEnLista(objetosIzq[i].ToString(), objetosDer))
                    {objetosDer.Add(objetosIzq[i].ToString());
                     objetosIzq.Remove(objetosIzq[i].ToString());}}}

        protected void btnEliminarItemDerecha(System.Object sender, System.EventArgs e)
            {if (objetosDer.Count > 0) { objetosDer.Remove(listDerecha.SelectedItem.ToString()); }
             else { MessageBox.Show("No hay elementos en la lista"); }}

        protected void btnPasarDeDerechaUno(System.Object sender, System.EventArgs e)
            {if (objetosDer.Count == 0) { MessageBox.Show("No hay elementos en la lista"); }
             if ((objetosDer.Count > 0) && validarPalabraEnLista(objetosDer[listDerecha.Items.IndexOf(listDerecha.SelectedItem)], objetosIzq))
                {objetosIzq.Add(objetosDer[listDerecha.Items.IndexOf(listDerecha.SelectedItem)]);
                 objetosDer.Remove(listDerecha.SelectedItem.ToString());}}

        private bool validarPalabraEnLista(string p, BindingList<string> l)
            {foreach (string s in l)
                {if (s.Equals(p))
                    {MessageBox.Show("Elemento repetido!");
                     return false; } }
             return true;
        }
    }
}
