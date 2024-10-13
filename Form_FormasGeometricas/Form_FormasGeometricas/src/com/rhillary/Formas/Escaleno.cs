using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form_FormasGeometricas.src.com.rhillary.Formas
{
    internal class Escaleno : Triangulo
    {
        public double l1 { get; set; }
        public double l2 { get; set; }
        public double l3 { get; set; }

        public Escaleno(double _l1, double _l2, double _l3) : base()
        {
            this.l1 = _l1;
            this.l2 = _l2;
            this.l3 = _l3;
        }

        public override double calcularArea()
        {
            return base.calcularArea();
        }

        public override double calcularPerimetro()
        {
            return l1 + l2 + l3;
        }

       
    }
}
