using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form_FormasGeometricas.src.com.rhillary.Formas
{
    internal class Circulo : Forma
    {
        public double raio { get; set; }

        public Circulo(double _raio)
        {
            this.raio = _raio;
        }

        public override double calcularArea()
        {
            return Math.PI * (raio * raio);
        }

        public override double calcularPerimetro()
        {
            return 2 * Math.PI * raio;
        }

      
    }
}
