using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ducks;

namespace ConsoleApp19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RedHeadDuck RD = new RedHeadDuck();
            Console.WriteLine(RD.Display());
            Console.WriteLine(RD.quack());
            Console.WriteLine(RD.fly());

            MallardDuck MD = new MallardDuck();
            Console.WriteLine(MD.Display());
            Console.WriteLine(MD.quack());
            Console.WriteLine(MD.fly());

            RubberDuck RubbD = new RubberDuck();
            Console.WriteLine(RubbD.Display());
            Console.WriteLine(RubbD.quack());

            DecoyDuck DD = new DecoyDuck();
            Console.WriteLine(DD.Display());

            Console.ReadKey();
        }
    }
}
