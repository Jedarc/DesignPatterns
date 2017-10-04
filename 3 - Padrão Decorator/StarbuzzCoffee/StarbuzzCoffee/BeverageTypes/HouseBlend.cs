using System;
using System.Collections.Generic;
using System.Text;
using StarbuzzCoffee.AbstractClass;

namespace StarbuzzCoffee.BeverageTypes
{
    public class HouseBlend: Beverage
    {
        public HouseBlend()
        {
            SetDescription("House Blend Coffee");
        }

        public override double Cost()
        {
            return .89;
        }

    }
}
