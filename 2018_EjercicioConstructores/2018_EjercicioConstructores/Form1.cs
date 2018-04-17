using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2018_EjercicioConstructores
{
    public partial class Form1 : Form
    {
        private List<Campo> campos = new List<Campo>();

        public Form1()
        {
            InitializeComponent();
        }

        private void altaCampoButton_Click(object sender, EventArgs e)
        {
            Campo c = new Campo();
            c.Precio += EventoPrecio;
            c.Tamaño += EventoTamaño;
            c.Ancho = double.Parse(Interaction.InputBox("Ancho?"));
            c.Largo = double.Parse(Interaction.InputBox("Largo?"));
            c.ValorM2 = decimal.Parse(Interaction.InputBox("Valor x m2?"));
            campos.Add(c);


            camposGrid.DataSource = null;
            camposGrid.DataSource = CampoVista.RetornaListaCampoVista(campos);
        }

        private void EventoTamaño(object sender, EventArgs e)
        {
            MessageBox.Show("Superaste los 25000 m2");
        }

        private void EventoPrecio(object sender, EventArgs e)
        {
            MessageBox.Show("Superaste el millón de pesos");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
