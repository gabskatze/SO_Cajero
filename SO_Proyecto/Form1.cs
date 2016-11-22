using System;
using System.Windows.Forms;

namespace SO_Proyecto
{
    public partial class Form1 : Form
    {
        private Datos datos;

        public Form1(Datos datos)
        {
            this.datos = datos;
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            RefrescarDatos();
        }

        private void RefrescarDatos()
        {
            lbxFila.DataSource = null;
            lbxFila.DataSource = datos.Personas;
            lblPersona1.Text = datos.Caja1;
            lblPersona2.Text = datos.Caja2;
            lblPersona3.Text = datos.Caja3;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            RefrescarDatos();
        }
    }
}
