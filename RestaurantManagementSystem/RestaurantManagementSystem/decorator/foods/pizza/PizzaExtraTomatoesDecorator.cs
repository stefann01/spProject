using RestaurantManagementSystem.enums.foods;
using RestaurantManagementSystem.helpers;
using RestaurantManagementSystem.interfaces.foods;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantManagementSystem.decorator.foods.pizza
{
    [Serializable]

    public class PizzaExtraTomatoesDecorator : Decorator<EPizzaType>
    {
        public PizzaExtraTomatoesDecorator(IDish<EPizzaType> decoratedObj) :
            base(
                decoratedObj,
                Constants.PizzaExtraTomatoesPrice,
                Constants.PizzaExtraTomatoesQuantity,
                new List<string>(Constants.PizzaExtraTomatoesIngredients)
            )
        { }
    }
}
