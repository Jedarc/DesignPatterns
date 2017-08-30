using System;
using SimUPato.SuperClass;
using SimUPato.Interfaces;
using SimUPato.Implementation;

namespace SimUPato.DerivedClass
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new Quack();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a model duck");
        }

    }
}
