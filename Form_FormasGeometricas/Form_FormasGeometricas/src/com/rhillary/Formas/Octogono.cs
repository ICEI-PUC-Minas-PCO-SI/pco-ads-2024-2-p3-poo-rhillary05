using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form_FormasGeometricas.src.com.rhillary.Formas
{
    internal class Octogono : Forma
    {
        public double lado { get; set; }

        public Octogono(double l) : base()
        {
            this.lado = l;
        }

        public override double calcularArea()
        {
            return 2 * (1 + Math.Sqrt(2)) * (lado * lado);
        }

        public override double calcularPerimetro()
        {
            return 8 * lado;
        }

        

    }
}
