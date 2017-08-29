using System;
using SimUPato.SuperClass;
using SimUPato.Interfaces;
using SimUPato.Implementation;

namespace SimUPato.DerivedClass
{
    public class MallardDuck : Duck 
    {
        public MallardDuck()
        {
            quackBehavior = new Quack();
            flyBehavior = new FlyWithWings();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a real Mallard duck");
        }
    }
}