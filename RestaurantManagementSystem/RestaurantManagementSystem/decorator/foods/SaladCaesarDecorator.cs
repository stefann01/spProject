using RestaurantManagementSystem.enums.foods;
using RestaurantManagementSystem.helpers;
using RestaurantManagementSystem.interfaces.foods;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantManagementSystem.decorator.foods
{
    public class SaladCaesarDecorator : SaladDecorator
    {
        public SaladCaesarDecorator(ISalad decoratedSalad) : base(decoratedSalad)
        {
            DecoratedSalad.Type = ESaladType.CAESAR;
            SetDish();
        }

        public override void SetDish()
        {
            DecoratedSalad.Price += Constants.SaladCaesarPrice;
            DecoratedSalad.Quantity += Constants.SaladCaesarQuantity;

            foreach (var ingredient in Constants.SaladCaesarIngredients)
            {
                if (!ContainsIngredient(ingredient))
                    DecoratedSalad.Ingredients.Add(ingredient);
            }
        }
    }
}
