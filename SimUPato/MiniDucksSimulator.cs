using System;
using SimUPato.DerivedClass;

namespace SimUPato
{
    public static class MiniDuckSimulator
    {
        static void Main()
        {
            var mallard = new MallardDuck();
            mallard.PerformQuack();
            mallard.PerformFly();

            Console.ReadKey();
        }
    }
}
