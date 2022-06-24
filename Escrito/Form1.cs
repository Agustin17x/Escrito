using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
namespace Escrito24_06_2022
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for(int x=1; x <= listaAmateurs.Count; x++)
            {
                lbAmateur.Items.Add(listaAmateurs.ToString());
            }
        }
        ArrayList listaAmateurs = new ArrayList();
        private void btnAmateurAgregar_Click(object sender, EventArgs e)
        {
            //string ci, string nombre, string fechaNac, int cantHoras, int sueldo
            Amateur amateur = new Amateur(txtCiAmateur.Text, txtNombreAmateur.Text, txtFechaNacAmateur.Text, Convert.ToInt32(txtCantHorasAmateur.Text), Convert.ToInt32(txtAntiguedad.Text));
            listaAmateurs.Add(amateur);
            lbAmateur.Items.Add(amateur.ToString());
            txtCiAmateur.Text = "";
            txtNombreAmateur.Text = "";
            txtFechaNacAmateur.Text = "";
            txtCantHorasAmateur.Text = "";
            txtAntiguedad.Text = "";
        }
        ArrayList listaProfesionales = new ArrayList();
        private void btnProfesionalAgregar_Click(object sender, EventArgs e)
        {
            Profesional profesional = new Profesional(txtCiProfesional.Text, txtNomProfesional.Text, txtFechaNacProfesional.Text, Convert.ToInt32(txtCantHorasProfesional.Text), Convert.ToInt32(txtSueldoProfesional.Text));
            listaProfesionales.Add(profesional);
            lbProfesional.Items.Add(profesional.ToString());
            txtCiProfesional.Text = "";
            txtNomProfesional.Text = "";
            txtFechaNacProfesional.Text = "";
            txtCantHorasProfesional.Text = "";
            txtSueldoProfesional.Text = "";
        }

        private void btnProfesionalListar_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiarProfesionales_Click(object sender, EventArgs e)
        {
            lbProfesional.Items.Clear();
        }

        private void btnLimpiarAmateur_Click(object sender, EventArgs e)
        {
            lbAmateur.Items.Clear();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    class Deportista
    {
        private string ci { set; get; }
        private string nombre { set; get; }
        private string fechaNac { set; get; }
        protected int cantHoras { set; get; }

        public Deportista()
        {
        }
        public Deportista(string ci, string nombre, string fechaNac, int cantHoras)
        {
            this.ci = ci;
            this.nombre = nombre;
            this.fechaNac = fechaNac;
            this.cantHoras = cantHoras;
        }

        override
        public string ToString()
        {
            return ("Ci: " + ci + ", Nombre: " + nombre + ", Fecha Nacimiento: " + fechaNac + ", CantHoras : " + cantHoras);
        }
    }

    class Amateur : Deportista
    {
        private int aniosAntiguedad { set; get; }

        public Amateur()
        {
        }
        public Amateur(string ci, string nombre, string fechaNac, int cantHoras, int aniosAntiguedad) : base(ci, nombre, fechaNac, cantHoras)
        {
            this.aniosAntiguedad = aniosAntiguedad;
        }

        public int costoMensual()
        {
            return cantHoras * 300;
        }

        override
        public string ToString()
        {
            return base.ToString() + ", Antiguedad: " + aniosAntiguedad + ", Costo Entreno: " + costoMensual();
        }
    }

    class Profesional : Deportista
    {
        private int sueldo { set; get; }

        public Profesional(string ci, string nombre, string fechaNac, int cantHoras, int sueldo) : base(ci, nombre, fechaNac, cantHoras)
        {
            this.sueldo = sueldo;
        }

        public int costoMensual()
        {
            return cantHoras * 30000;
        }

        public string ToString()
        {
            return base.ToString() + ", Costo Mensual: " + " " +(costoMensual() + sueldo);
        }

    }
}
