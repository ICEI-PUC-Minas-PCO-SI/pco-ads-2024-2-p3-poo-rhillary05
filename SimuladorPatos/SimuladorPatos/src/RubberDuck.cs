using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorPatos.src
{
    public class RubberDuck : Duck, IQackable, ISwimmable
    {
        public override void Display()
        {
            Console.WriteLine("Displaying a Rubber Duck");
        }


        public void Quack()
        {
            Console.WriteLine("The  RubberDuck is quacking");

        }

        public void Swin()
        {
            Console.WriteLine("The RubberDuck is swimming");
        }

        public static void Executar()
        {
            RubberDuck patoBorracha = new RubberDuck();
            patoBorracha.Display();
            patoBorracha.Quack();
            patoBorracha.Swin();
        }

    }
}
