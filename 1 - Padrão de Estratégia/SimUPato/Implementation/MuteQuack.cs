using System;
using SimUPato.Interfaces;

namespace SimUPato.Implementation
{
    public class MuteQuack : QuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("<< Silence >>");
        }
    }
}