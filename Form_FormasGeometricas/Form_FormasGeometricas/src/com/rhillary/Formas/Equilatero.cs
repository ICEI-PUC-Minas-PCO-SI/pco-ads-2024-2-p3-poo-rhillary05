using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form_FormasGeometricas.src.com.rhillary.Formas
{
    internal class Equilatero : Triangulo
    {
        public double lado { get; set; }

        public Equilatero(double _lado) : base()
        {
            this.lado = _lado;
        }

        public override double calcularArea()
        {
            return (Math.Sqrt(3) / 4) * (lado * lado);
        }

        public override double calcularPerimetro()
        {
            return 3 * lado;
        }

        

    }
}
