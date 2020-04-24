using RestaurantManagementSystem.enums.foods;
using RestaurantManagementSystem.helpers;
using RestaurantManagementSystem.interfaces.foods;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantManagementSystem.decorator.foods.salad
{
    [Serializable]
    public class SaladExtraMozzarellaDecorator : Decorator<ESaladType>
    {
        public SaladExtraMozzarellaDecorator(IDish<ESaladType> decoratedObj) :
            base(
                decoratedObj,
                Constants.SaladExtraMozzarellaPrice,
                Constants.SaladExtraMozzarellaQuantity,
                new List<string>(Constants.SaladExtraMozzarellaIngredients)
            )
        { }
    }
}
