using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorPatos.src
{
    public class MallardDuck : Duck, IFlayable, IQackable, ISwimmable
    {
        public override void Display()
        {
            Console.WriteLine("Displaying a Mallard Duck");
        }

        public void Fly()
        {
            Console.WriteLine("The MallardDuck is flying");
        }

        public void Quack()
        {
            Console.WriteLine("The MallardDuck is quacking");

        }

        public void Swin()
        {
            Console.WriteLine("The MallardDuck is swimming");
        }

        public static void Executar()
        {
            MallardDuck patomal = new MallardDuck();
            patomal.Display();
            patomal.Fly();
            patomal .Quack();
            patomal .Swin();
        }


    }
}
