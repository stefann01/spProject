using RestaurantManagementSystem.enums.foods;
using RestaurantManagementSystem.helpers;
using RestaurantManagementSystem.interfaces.foods;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantManagementSystem.decorator.foods.salads
{
    [Serializable]
    public class DrinkColaDecorator : Decorator<EDrinkType>
    {
        public DrinkColaDecorator(IDish<EDrinkType> decoratedObj) :
            base(
                decoratedObj,
                EDrinkType.COLA,
                Constants.DrinkColaPrice,
                Constants.DrinkColaQuantity,
                new List<string>(Constants.DrinkColaIngredients)
            )
        { }
    }
}
