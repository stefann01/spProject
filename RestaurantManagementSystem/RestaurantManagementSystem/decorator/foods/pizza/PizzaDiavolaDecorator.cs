using RestaurantManagementSystem.enums.foods;
using RestaurantManagementSystem.helpers;
using RestaurantManagementSystem.interfaces.foods;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantManagementSystem.decorator.foods.pizza
{
    public class PizzaDiavolaDecorator : Decorator<EPizzaType>
    {
        public PizzaDiavolaDecorator(IDish<EPizzaType> decoratedObj) :
            base(
                decoratedObj,
                EPizzaType.DIAVOLA,
                Constants.PizzaDiavolaPrice,
                Constants.PizzaDiavolaQuantity,
                new List<string>(Constants.PizzaDiavolaIngredients)
            )
        { }
    }
}
