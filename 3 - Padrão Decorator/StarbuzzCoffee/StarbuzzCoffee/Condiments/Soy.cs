using StarbuzzCoffee.AbstractClass;
using StarbuzzCoffee.DecoratorClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace StarbuzzCoffee.Condiments
{
    public class Soy : CondimentDecorator
    {
        Beverage beverage;

        public Soy(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Soy";
        }

        public override double Cost()
        {
            return .15 + beverage.Cost();
        }
    }
}
