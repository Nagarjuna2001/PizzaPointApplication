using PizzaPointApplication.Models.Component;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaPointApplication.Models.ConcreteComponent
{
    public class FlatBreadPizza : AbstractPizza
    {
        public FlatBreadPizza()
        {
            this.Description = "This is a FlatBread pizza";
        }

        public override string GetDescription()
        {
            return Description;
        }

        public override int GetPrice()
        {
            return 100;
        }
    }
}
