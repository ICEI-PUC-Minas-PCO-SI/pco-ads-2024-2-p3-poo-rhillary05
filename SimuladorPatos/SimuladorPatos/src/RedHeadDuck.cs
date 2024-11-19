using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorPatos.src
{
    public class RedHeadDuck: Duck, IFlayable, IQackable, ISwimmable
    {
        public override void Display()
        {
            Console.WriteLine("Displaying a RedHead Duck");
        }

        public void Fly()
        {
            Console.WriteLine("The RedHeadDuck is flying");
        }

        public void Quack()
        {
            Console.WriteLine("The RedHeadDuck is quacking");

        }

        public void Swin()
        {
            Console.WriteLine("The RedHeadDuck is swimming");
        }

        public static void Executar ()
        {
            RedHeadDuck patoVermelho = new RedHeadDuck();
            patoVermelho.Display();
            patoVermelho.Fly();
            patoVermelho.Quack();
            patoVermelho.Swin();
        }

    }
}
