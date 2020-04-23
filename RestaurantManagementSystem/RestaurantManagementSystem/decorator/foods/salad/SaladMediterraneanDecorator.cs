using RestaurantManagementSystem.enums.foods;
using RestaurantManagementSystem.helpers;
using RestaurantManagementSystem.interfaces.foods;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantManagementSystem.decorator.foods.salads
{
    public class SaladMediterraneanDecorator : Decorator<ESaladType>
    {
        public SaladMediterraneanDecorator(IDish<ESaladType> decoratedObj) :
            base(
                decoratedObj,
                ESaladType.MEDITERRANEAN,
                Constants.SaladMediterraneanPrice,
                Constants.SaladMediterraneanQuantity,
                new List<string>(Constants.SaladMediterraneanIngredients)
            )
        { }
    }
}
