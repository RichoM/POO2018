using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2018_EjercicioConstructores
{
    class Campo
    {
        public event EventHandler Tamaño;
        public event EventHandler Precio;

        private double largo;
        private double ancho;
        private decimal valorM2;

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

        #region Propiedades
        public double Ancho
        {
            get { return ancho; }
            set
            {
                ancho = value;
                ChequearSuperficie();
            }
        }

        public double Largo
        {
            get { return largo; }
            set
            {
                largo = value;
                ChequearSuperficie();
            }
        }

        public decimal ValorM2
        {
            get { return valorM2; }
            set
            {
                valorM2 = value;
                ChequearCosto();
            }
        }
        #endregion

        private void ChequearCosto()
        {
            if (CalcularCostoTotal() > 1000000)
            {
                if (Precio != null)
                {
                    Precio(this, new EventArgs());
                }
            }
        }

        private void ChequearSuperficie()
        {
            if (CalcularSuperficie() > 25000)
            {
                if (Tamaño != null)
                {
                    Tamaño(this, new EventArgs());
                }
            }

            ChequearCosto();
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
