using System;
using System.Collections.Generic;
using System.Text;
using StarbuzzCoffee.AbstractClass;

namespace StarbuzzCoffee.BeverageTypes
{
    public class DarkRoast: Beverage
    {
        public DarkRoast()
        {
            SetDescription("DarkRoast");
        }

        public override double Cost()
        {
            return .99;
        }
    }
}
