using System;
using System.Collections.Generic;
using System.Text;
using StarbuzzCoffee.DecoratorClass;
using StarbuzzCoffee.AbstractClass;

namespace StarbuzzCoffee.Condiments
{
    public class Mocha : CondimentDecorator
    {
        Beverage beverage;

        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Mocha";
        }

        public override double Cost()
        {
            return .20 + beverage.Cost();
        }
    }
}
