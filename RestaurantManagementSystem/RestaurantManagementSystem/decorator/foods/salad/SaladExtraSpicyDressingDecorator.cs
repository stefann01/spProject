using RestaurantManagementSystem.enums.foods;
using RestaurantManagementSystem.helpers;
using RestaurantManagementSystem.interfaces.foods;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantManagementSystem.decorator.foods.salad
{
    [Serializable]
    public class SaladExtraSpicyDressingDecorator : Decorator<ESaladType>
    {
        public SaladExtraSpicyDressingDecorator(IDish<ESaladType> decoratedObj) :
            base(
                decoratedObj,
                Constants.SaladExtraSpicyDressingPrice,
                Constants.SaladExtraSpicyDressingQuantity,
                new List<string>(Constants.SaladExtraSpicyDressingIngredients)
            )
        { }
    }
}
