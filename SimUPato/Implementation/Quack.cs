using System;
using SimUPato.Interfaces;

namespace SimUPato.Implementation
{
    public class Quack : QuackBehavior
    {
        void QuackBehavior.Quack()
        {
            Console.WriteLine("Quack");
        }
    }
}