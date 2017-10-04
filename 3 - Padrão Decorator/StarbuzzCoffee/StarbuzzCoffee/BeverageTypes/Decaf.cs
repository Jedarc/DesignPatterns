using System;
using System.Collections.Generic;
using System.Text;
using StarbuzzCoffee.AbstractClass;

namespace StarbuzzCoffee.BeverageTypes
{
    public class Decaf: Beverage
    {
        public Decaf()
        {
            SetDescription("Decaf");
        }

        public override double Cost()
        {
            return 1.05;
        }
    }
}
