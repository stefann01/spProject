using RestaurantManagementSystem.enums.foods;
using RestaurantManagementSystem.helpers;
using RestaurantManagementSystem.interfaces.foods;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantManagementSystem.decorator.foods.salads
{
    [Serializable]
    public class SaladCaesarDecorator : Decorator<ESaladType>
    {
        public SaladCaesarDecorator(IDish<ESaladType> decoratedObj) :
            base(
                decoratedObj,
                ESaladType.CAESAR,
                Constants.SaladCaesarPrice,
                Constants.SaladCaesarQuantity,
                new List<string>(Constants.SaladCaesarIngredients)
            )
        { }
    }
}
