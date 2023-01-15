using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PolimorfismoTP.Aviones;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnComercial_Click(object sender, EventArgs e)
        {
            AvionComercial avioncomercial = new AvionComercial(" Luis Gomez ", 200, " Aerolineas Argentinas ", " Thiago Ruiz ", " Melisa Perez ");
           
            MessageBox.Show( avioncomercial.ToString() + "\n" + avioncomercial.Despega() + "\n" + avioncomercial.Aterriza());


        }

        private void button1_Click(object sender, EventArgs e)
        {

            AvionCarga avioncarga = new AvionCarga(" Julio Boldo ",3304, " Alimentos", " Miguel Valdez ", " Jimena Carlson ");

            MessageBox.Show(avioncarga.ToString() + "\n" + avioncarga.Despega() + "\n" + avioncarga.Aterriza());
        }
    }
}
