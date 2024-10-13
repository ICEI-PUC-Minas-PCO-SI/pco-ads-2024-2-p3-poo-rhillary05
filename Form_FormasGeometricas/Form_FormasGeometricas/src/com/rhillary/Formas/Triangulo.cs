using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form_FormasGeometricas.src.com.rhillary.Formas
{
    internal class Triangulo : Forma
    {
        public double lado1 { get; set; }
        public double lado2 { get; set; }
        public double lado3 { get; set; }

        public Triangulo() { }

        public Triangulo(double l1, double l2, double l3)
        {
            this.lado1 = l1;
            this.lado2 = l2;
            this.lado3 = l3;
        }

        public override double calcularArea()
        {
            double semiPerimetro = calcularPerimetro() / 2;
            return Math.Sqrt(semiPerimetro * (semiPerimetro - lado1) * (semiPerimetro - lado2) * (semiPerimetro - lado3));
        }

        public override double calcularPerimetro()
        {
            return lado1 + lado2 + lado3;
        }

        
    }
}
