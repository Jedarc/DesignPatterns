using System;
using SimUPato.Interfaces;

namespace SimUPato.Implementation
{
    public class FlyRocketPowered : FlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying with a rocket!");
        }
    }
}
