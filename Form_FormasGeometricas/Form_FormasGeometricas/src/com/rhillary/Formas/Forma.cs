using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form_FormasGeometricas.src.com.rhillary.Formas
{
    public abstract class Forma
    {
        public Forma() { }
        public abstract double calcularArea();
        public abstract double calcularPerimetro();


    }
}
