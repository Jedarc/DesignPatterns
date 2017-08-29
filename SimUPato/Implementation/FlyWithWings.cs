
using System;
using SimUPato.Interfaces;

namespace SimUPato.Implementation
{
    public class FlyWithWings : FlyBehavior {
        public void Fly(){
            Console.WriteLine("I'm flying!");
        }
    }
}
