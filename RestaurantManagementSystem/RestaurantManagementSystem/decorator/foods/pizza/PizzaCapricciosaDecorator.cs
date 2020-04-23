using RestaurantManagementSystem.enums.foods;
using RestaurantManagementSystem.helpers;
using RestaurantManagementSystem.interfaces.foods;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantManagementSystem.decorator.foods.pizza
{
    [Serializable]

    public class PizzaCapricciosaDecorator : Decorator<EPizzaType>
    {
        public PizzaCapricciosaDecorator(IDish<EPizzaType> decoratedObj) :
            base(
                decoratedObj,
                EPizzaType.CAPRICCIOSA,
                Constants.PizzaCapricciosaPrice,
                Constants.PizzaCapricciosaQuantity,
                new List<string>(Constants.PizzaCapricciosaIngredients)
            )
        { }
    }
}
