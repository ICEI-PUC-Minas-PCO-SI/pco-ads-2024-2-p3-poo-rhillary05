using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form_FormasGeometricas.src.com.rhillary.Formas
{
    internal class Pentagono: Forma
    {
        public double lado { get; set; }

        public Pentagono(double l) : base()
        {
            this.lado = l;
        }

        public override double calcularArea()
        {
            double apotema = lado / (2 * Math.Tan(Math.PI / 5));
            return (5 * lado * apotema);
        }

        public override double calcularPerimetro()
        {
            return 5 * lado;
        }

        
    }
}
