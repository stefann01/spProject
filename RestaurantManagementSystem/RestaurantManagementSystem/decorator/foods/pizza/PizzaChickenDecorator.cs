using RestaurantManagementSystem.enums.foods;
using RestaurantManagementSystem.helpers;
using RestaurantManagementSystem.interfaces.foods;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantManagementSystem.decorator.foods.pizza
{
    public class PizzaChickenDecorator : Decorator<EPizzaType>
    {
        public PizzaChickenDecorator(IDish<EPizzaType> decoratedObj) :
            base(
                decoratedObj,
                EPizzaType.CHICKEN,
                Constants.PizzaChickenPrice,
                Constants.PizzaChickenQuantity,
                new List<string>(Constants.PizzaChickenIngredients)
            )
        { }
    }
}
