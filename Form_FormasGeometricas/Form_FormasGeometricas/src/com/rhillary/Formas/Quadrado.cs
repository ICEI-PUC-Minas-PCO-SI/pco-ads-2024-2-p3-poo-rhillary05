using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form_FormasGeometricas.src.com.rhillary.Formas
{
    internal class Quadrado : Forma
    {
        public double lado { get; set; }

        public Quadrado(double _lado)
        {
            this.lado = _lado;
        }

        public override double calcularArea()
        {
            return (lado * lado);
        }

        public override double calcularPerimetro()
        {
            return (4 * lado);
        }

       
    }
}
