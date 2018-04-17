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

        private Campo CampoSeleccionado
        {
            get
            {
                if (camposGrid.SelectedRows.Count == 0) return null;
                return ((CampoVista)camposGrid.SelectedRows[0].DataBoundItem).Origen();
            }
        }

        private void altaCampoButton_Click(object sender, EventArgs e)
        {
            Campo c = new Campo();
            c.Precio += EventoPrecio;
            c.Tamaño += EventoTamaño;
            ConfigurarCampo(c);
            campos.Add(c);

            ActualizarGrilla();
        }

        private static void ConfigurarCampo(Campo c)
        {
            c.Ancho = double.Parse(Interaction.InputBox("Ancho?", "", c.Ancho.ToString()));
            c.Largo = double.Parse(Interaction.InputBox("Largo?", "", c.Largo.ToString()));
            c.ValorM2 = decimal.Parse(Interaction.InputBox("Valor x m2?", "", c.ValorM2.ToString()));
        }

        private void ActualizarGrilla()
        {
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
            camposGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void borrarCampoButton_Click(object sender, EventArgs e)
        {
            if (CampoSeleccionado != null)
            {
                campos.Remove(CampoSeleccionado);
                CampoSeleccionado.Dispose();
                ActualizarGrilla();
            }
        }

        private void modificarCampoButton_Click(object sender, EventArgs e)
        {
            if (CampoSeleccionado != null)
            {
                ConfigurarCampo(CampoSeleccionado);
                ActualizarGrilla();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cant = int.Parse(Interaction.InputBox("Cantidad?"));
            for (int i = 0; i < cant; i++)
            {
                Campo c = new Campo(1, 2, 3);
                campos.Add(c);
            }
            ActualizarGrilla();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GC.Collect();
        }
    }
}
