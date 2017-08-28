using System;
using SimUPato.Interfaces;

namespace SimUPato.Implementation 
{
    public class FlyNoWay : FlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("I can't fly");
        }
    }
}