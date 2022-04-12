
using PizzaPointApplication.Models.Component;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaPointApplication.Models.Decorator
{
    public class PizzaDecorator : AbstractPizza
    {
        protected AbstractPizza PizzaOptedByCustomer;

        public PizzaDecorator(AbstractPizza pizza)
        {
            PizzaOptedByCustomer = pizza;
        }

        public override string GetDescription()
        {
            return PizzaOptedByCustomer.Description;
        }

        public override int GetPrice()
        {
            return PizzaOptedByCustomer.GetPrice();
        }
    }
}
