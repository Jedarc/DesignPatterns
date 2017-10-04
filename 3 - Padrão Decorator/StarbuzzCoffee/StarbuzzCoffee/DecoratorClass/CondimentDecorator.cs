using System;
using System.Collections.Generic;
using System.Text;
using StarbuzzCoffee.AbstractClass;

namespace StarbuzzCoffee.DecoratorClass
{
    public abstract class CondimentDecorator : Beverage
    {
        public override abstract string GetDescription();
    }
}
