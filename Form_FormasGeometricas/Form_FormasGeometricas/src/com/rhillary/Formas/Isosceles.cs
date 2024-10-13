using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form_FormasGeometricas.src.com.rhillary.Formas
{
    internal class Isosceles : Triangulo
    {
        public double lbase { get; set; }

        public double altura { get; set; }

        public double lado { get; set; }

        public Isosceles(double _base, double _altura, double _lado) : base()
        {
            this.lbase = _base;
            this.altura = _altura;
            this.lado = _lado;
        }

        public override double calcularArea()
        {
            return (lbase * altura) / 2;
        }

        public override double calcularPerimetro()
        {
            return (2 * lado) + lbase;
        }

       
    }
}
