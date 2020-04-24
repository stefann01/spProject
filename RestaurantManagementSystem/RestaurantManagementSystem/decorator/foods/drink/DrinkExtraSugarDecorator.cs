using RestaurantManagementSystem.enums.foods;
using RestaurantManagementSystem.helpers;
using RestaurantManagementSystem.interfaces.foods;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantManagementSystem.decorator.foods.salads
{

    [Serializable]
    public class DrinkExtraSugarDecorator : Decorator<EDrinkType>
    {
        public DrinkExtraSugarDecorator(IDish<EDrinkType> decoratedObj) :
            base(
                decoratedObj,
                Constants.DrinkExtraSugarPrice,
                Constants.DrinkExtraSugarQuantity,
                new List<string>(Constants.DrinkExtraSugarIngredients)
            )
        { }
    }
}
