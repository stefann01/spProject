using RestaurantManagementSystem.enums.foods;
using RestaurantManagementSystem.helpers;
using RestaurantManagementSystem.interfaces.foods;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantManagementSystem.decorator.foods.salads
{
    public class DrinkCherrySodaDecorator : Decorator<EDrinkType>
    {
        public DrinkCherrySodaDecorator(IDish<EDrinkType> decoratedObj) :
            base(
                decoratedObj,
                EDrinkType.CHERRY_SODA,
                Constants.DrinkCherrySodaPrice,
                Constants.DrinkCherrySodaQuantity,
                new List<string>(Constants.DrinkCherrySodaIngredients)
            )
        { }
    }
}
