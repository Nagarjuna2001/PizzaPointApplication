
using PizzaPointApplication.Models.Component;
using PizzaPointApplication.Models.Decorator;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaPointApplication.Models.ConcreteDecorators
{
    public class ExtraCheese : PizzaDecorator
    {

        public ExtraCheese(AbstractPizza pizza) : base(pizza)
        {

        }
        public override string GetDescription()
        {
            return PizzaOptedByCustomer.GetDescription() + " with extra Cheese";
        }

        public override int GetPrice()
        {
            return PizzaOptedByCustomer.GetPrice() + 40;
        }
    }
}
