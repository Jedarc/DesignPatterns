using System;
using SimUPato.Interfaces;

namespace SimUPato.Implementation
{
    public class MuteQuack : QuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("<< Silence >>");
        }
    }
}