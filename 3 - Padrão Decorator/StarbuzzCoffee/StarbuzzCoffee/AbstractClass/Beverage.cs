using System;
using System.Collections.Generic;
using System.Text;

namespace StarbuzzCoffee.AbstractClass
{
    public abstract class Beverage
    {
        private string description = "Unknown Beverage";

        public void SetDescription(string description)
        {
            this.description = description;
        }

        public virtual string GetDescription()
        {
            return description;
        }

        public abstract double Cost();

    }
}
