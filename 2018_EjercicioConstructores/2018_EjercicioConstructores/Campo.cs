using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2018_EjercicioConstructores
{
    class Campo
    {
        public double Largo { get; set; }
        public double Ancho { get; set; }
        public decimal ValorM2 { get; set; }

        public Campo()
        {}

        public Campo(double ancho)
            : this()
        {
            Ancho = ancho;
        }

        public Campo(double ancho, double largo)
            : this(ancho)
        {
            Largo = largo;
        }

        public Campo(double ancho, double largo, decimal valor)
            : this(ancho, largo)
        {
            ValorM2 = valor;
        }

        public double CalcularSuperficie()
        {
            return Largo * Ancho;
        }

        public decimal CalcularCostoTotal()
        {
            return (decimal)CalcularSuperficie() * ValorM2;
        }

    }
}
