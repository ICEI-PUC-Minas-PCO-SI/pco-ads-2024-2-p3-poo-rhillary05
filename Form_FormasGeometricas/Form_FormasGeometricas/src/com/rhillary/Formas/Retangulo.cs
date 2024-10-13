using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form_FormasGeometricas.src.com.rhillary.Formas
{
    internal class Retangulo : Forma
    {
        public double altura { get; set; }
        public double largra { get; set; }

        public Retangulo(double _altura, double _largra)
        {
            this.altura = _altura;
            this.largra = _largra;
        }

        public override double calcularArea()
        {
            return largra * altura;
        }

        public override double calcularPerimetro()
        {
            return 2 * (largra + altura);
        }

       
    }
}
