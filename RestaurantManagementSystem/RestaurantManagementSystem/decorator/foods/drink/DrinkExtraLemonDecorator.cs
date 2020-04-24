using RestaurantManagementSystem.enums.foods;
using RestaurantManagementSystem.helpers;
using RestaurantManagementSystem.interfaces.foods;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantManagementSystem.decorator.foods.salads
{

    [Serializable]
    public class DrinkExtraLemonDecorator : Decorator<EDrinkType>
    {
        public DrinkExtraLemonDecorator(IDish<EDrinkType> decoratedObj) :
            base(
                decoratedObj,
                Constants.DrinkExtraLemonPrice,
                Constants.DrinkExtraLemonQuantity,
                new List<string>(Constants.DrinkExtraLemonIngredients)
            )
        { }
    }
}
