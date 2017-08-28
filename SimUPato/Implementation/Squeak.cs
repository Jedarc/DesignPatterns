using System;
using SimUPato.Interfaces;

namespace SimUPato.Implementation
{
    public class Squeak : QuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("Squeak");
        }
    }
}