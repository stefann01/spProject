using RestaurantManagementSystem.enums.foods;
using RestaurantManagementSystem.helpers;
using RestaurantManagementSystem.interfaces.foods;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantManagementSystem.decorator.foods.salads
{
    [Serializable]
    public class DrinkOrangeJuiceDecorator : Decorator<EDrinkType>
    {
        public DrinkOrangeJuiceDecorator(IDish<EDrinkType> decoratedObj) :
            base(
                decoratedObj,
                EDrinkType.ORANGE_JUICE,
                Constants.DrinkOrangeJuicePrice,
                Constants.DrinkOrangeJuiceQuantity,
                new List<string>(Constants.DrinkOrangeJuiceIngredients)
            )
        { }
    }
}
