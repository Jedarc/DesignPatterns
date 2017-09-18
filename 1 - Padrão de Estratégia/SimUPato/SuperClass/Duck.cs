using System;
using SimUPato.Interfaces;

namespace SimUPato.SuperClass
{
    public abstract class Duck
    {
        public FlyBehavior flyBehavior;
        public QuackBehavior quackBehavior;

        public Duck()
        {
        }

        public abstract void Display();

        public void PerformFly()
        {
            flyBehavior.Fly();
        }

        public void PerformQuack()
        {
            quackBehavior.Quack();
        }

        public void SetFlyBehavior(FlyBehavior fb)
        {
            flyBehavior = fb;
        }

        public void SetQuackBehavior(QuackBehavior qb)
        {
            quackBehavior = qb;
        }

        public void Swim()
        {
            Console.WriteLine("All ducks float, even decoys!");
        }

    }
}
