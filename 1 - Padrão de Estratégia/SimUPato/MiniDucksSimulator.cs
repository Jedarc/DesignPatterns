using System;
using SimUPato.DerivedClass;
using SimUPato.Implementation;

namespace SimUPato
{
    public static class MiniDuckSimulator
    {
        static void Main()
        {
            var mallard = new MallardDuck();
            mallard.PerformQuack();
            mallard.PerformFly();

            Console.WriteLine();
            Console.WriteLine("--- Dynamic behavior ---");

            var model = new ModelDuck();
            model.PerformFly();
            model.SetFlyBehavior(new FlyRocketPowered());
            model.PerformFly();

            Console.ReadKey();
        }
    }
}
