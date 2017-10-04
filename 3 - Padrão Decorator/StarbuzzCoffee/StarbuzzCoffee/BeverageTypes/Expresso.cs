using System;
using System.Collections.Generic;
using System.Text;
using StarbuzzCoffee.AbstractClass;

namespace StarbuzzCoffee.BeverageTypes
{
    public class Expresso : Beverage
    {
        public Expresso()
        {
            SetDescription("Expresso");
        }

        public override double Cost()
        {
            return 1.99;
        }

    }
}
