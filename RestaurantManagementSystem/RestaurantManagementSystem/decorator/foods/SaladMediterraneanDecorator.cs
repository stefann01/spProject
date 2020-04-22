using RestaurantManagementSystem.enums.foods;
using RestaurantManagementSystem.helpers;
using RestaurantManagementSystem.interfaces.foods;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantManagementSystem.decorator.foods
{
    class SaladMediterraneanDecorator : SaladDecorator
    {
        public SaladMediterraneanDecorator(ISalad decoratedSalad) : base(decoratedSalad)
        {
            DecoratedSalad.Type = ESaladType.MEDITERRANEAN;
            SetDish();
        }

        public override void SetDish()
        {
            DecoratedSalad.Price += Constants.SaladMediterraneanPrice;
            DecoratedSalad.Quantity += Constants.SaladMediterraneanQuantity;

            foreach (var ingredient in Constants.SaladMediterraneanIngredients)
            {
                if (!ContainsIngredient(ingredient))
                    DecoratedSalad.Ingredients.Add(ingredient);
            }
        }
    }
}
