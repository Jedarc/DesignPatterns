using StarbuzzCoffee.AbstractClass;
using StarbuzzCoffee.DecoratorClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace StarbuzzCoffee.Condiments
{
    public class Whip : CondimentDecorator
    {
        Beverage beverage;

        public Whip(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Soy";
        }

        public override double Cost()
        {
            return .10 + beverage.Cost();
        }
    }
}
