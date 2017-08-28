
using System;
using SimUPato.Interfaces;

namespace SimUPato.Implementation
{
    public class FlyWithWings : FlyBehavior {
        public void fly(){
            Console.WriteLine("I'm flying!");
        }
    }
}
