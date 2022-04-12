
using PizzaPointApplication.Models.Component;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaPointApplication.Models
{
    public interface IOrder
    {
        AbstractPizza GetPizzaType(string customerEnteredPizzaType);

        AbstractPizza GetToppingOptedByUser(string customerEnteredToppingType,AbstractPizza pizzaType);
    }
}
