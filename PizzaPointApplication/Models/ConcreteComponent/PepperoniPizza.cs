﻿
using PizzaPointApplication.Models.Component;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaPointApplication.Models.ConcreteComponent
{
    public class PepperoniPizza : AbstractPizza
    {
        public PepperoniPizza()
        {
            this.Description = "This is a Pepperoni pizza";
        }

        public override string GetDescription()
        {
            return Description;
        }

        public override int GetPrice()
        {
            return 150;
        }
    }
}
