using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form_FormasGeometricas.src.com.rhillary.Formas
{
    internal class Hexagono: Forma
    {
        public double lado { get; set; }

        public Hexagono(double l) : base()
        {
            this.lado = l;
        }

        public override double calcularArea()
        {
            return ((3 * Math.Sqrt(3)) / 2) * (lado * lado);
        }

        public override double calcularPerimetro()
        {
            return 6 * lado;
        }

        
    }
}
