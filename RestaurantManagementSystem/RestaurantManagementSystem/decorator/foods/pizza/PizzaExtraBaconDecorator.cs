using RestaurantManagementSystem.enums.foods;
using RestaurantManagementSystem.helpers;
using RestaurantManagementSystem.interfaces.foods;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantManagementSystem.decorator.foods.pizza
{
    [Serializable]

    public class PizzaExtraBaconDecorator : Decorator<EPizzaType>
    {
        public PizzaExtraBaconDecorator(IDish<EPizzaType> decoratedObj) :
            base(
                decoratedObj,
                Constants.PizzaExtraBaconPrice,
                Constants.PizzaExtraBaconQuantity,
                new List<string>(Constants.PizzaExtraBaconIngredients)
            )
        { }
    }
}
