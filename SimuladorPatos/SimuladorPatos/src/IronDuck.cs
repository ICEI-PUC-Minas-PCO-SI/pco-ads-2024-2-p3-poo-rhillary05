using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorPatos.src
{
    public class IronDuck : Duck
    {
        public override void Display()
        {
            Console.WriteLine("Displaying a Iron Duck");
        }

        public void jogarPato()
        {
            Console.WriteLine("Iron Duck foi lançado no inimigo isso pode machucar!!");
        }

        public static void Executar()
        {
            IronDuck PatoFerro = new IronDuck();
            PatoFerro.Display();
            PatoFerro.jogarPato();
        }

    }
}
