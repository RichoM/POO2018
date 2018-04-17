using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2018_EjercicioConstructores
{
    class CampoVista
    {
        public static List<CampoVista> RetornaListaCampoVista(List<Campo> listaCampos)
        {
            List<CampoVista> listaCampoVista = new List<CampoVista>();
            foreach (Campo campo in listaCampos)
            {
                //CampoVista campoVista = new CampoVista(campo);
                //listaCampoVista.Add(campoVista);
                listaCampoVista.Add(new CampoVista(campo));
            }
            return listaCampoVista;
        }

        private Campo origen;

        public CampoVista(Campo campo)
        {
            origen = campo;
            Ancho = campo.Ancho;
            Largo = campo.Largo;
            ValorM2 = campo.ValorM2;
            Superficie = campo.CalcularSuperficie();
            CostoTotal = campo.CalcularCostoTotal();
        }

        public double Ancho { get; set; }
        public double Largo { get; set; }
        public decimal ValorM2 { get; set; }
        public double Superficie { get; set; }
        public decimal CostoTotal { get; set; }

        public Campo Origen()
        {
            return origen;
        }
    }
}
