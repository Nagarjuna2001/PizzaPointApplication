﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaPointApplication.Models.Component
{
    public abstract class AbstractPizza
    {
        public AbstractPizza()
        {

        }

        public string Description { get; set; }
        public abstract string GetDescription();

        public abstract int GetPrice();

    }
}
