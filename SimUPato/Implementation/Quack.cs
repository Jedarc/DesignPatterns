using System;
using SimUPato.Interfaces;

namespace SimUPato.Implementation
{
    public class Quack : QuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("Quack");
        }
    }
}