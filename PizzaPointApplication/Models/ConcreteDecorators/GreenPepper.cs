
using PizzaPointApplication.Models.Component;
using PizzaPointApplication.Models.Decorator;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaPointApplication.Models.ConcreteDecorators
{
    public class GreenPepper : PizzaDecorator
    {
        public GreenPepper(AbstractPizza pizza) : base(pizza)
        {

        }
        public override string GetDescription()
        {
            return PizzaOptedByCustomer.GetDescription() + " with added Green Pepper";
        }
        public override int GetPrice()
        {
            return PizzaOptedByCustomer.GetPrice() + 30;
        }
    }
}
