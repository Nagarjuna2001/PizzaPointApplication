﻿
using PizzaPointApplication.Models.Component;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaPointApplication.Models.ConcreteComponent
{
    public class ChickenPizza : AbstractPizza
    {
        public ChickenPizza()
        {
            this.Description = "This is a delicious chicken pizza";
        }

        public override string GetDescription()
        {
            return Description;
        }

        public override int GetPrice()
        {
            return 200;
        }
    }
}
