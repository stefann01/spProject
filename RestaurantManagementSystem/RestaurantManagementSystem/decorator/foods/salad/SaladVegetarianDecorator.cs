using RestaurantManagementSystem.enums.foods;
using RestaurantManagementSystem.helpers;
using RestaurantManagementSystem.interfaces.foods;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantManagementSystem.decorator.foods.salads
{
    [Serializable]

    public class SaladVegetarianDecorator : Decorator<ESaladType>
    {
        public SaladVegetarianDecorator(IDish<ESaladType> decoratedObj) :
            base(
                decoratedObj,
                ESaladType.VEGETARIAN,
                Constants.SaladVegetarianPrice,
                Constants.SaladVegetarianQuantity,
                new List<string>(Constants.SaladVegetarianIngredients)
            )
        { }
    }
}
