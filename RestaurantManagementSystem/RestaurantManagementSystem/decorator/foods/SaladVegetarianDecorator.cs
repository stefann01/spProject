using RestaurantManagementSystem.enums.foods;
using RestaurantManagementSystem.helpers;
using RestaurantManagementSystem.interfaces.foods;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantManagementSystem.decorator.foods
{
    class SaladVegetarianDecorator : SaladDecorator
    {
        public SaladVegetarianDecorator(ISalad decoratedSalad) : base(decoratedSalad)
        {
            DecoratedSalad.Type = ESaladType.VEGETARIAN;
            SetDish();
        }

        public override void SetDish()
        {
            DecoratedSalad.Price += Constants.SaladVegetarianPrice;
            DecoratedSalad.Quantity += Constants.SaladVegetarianQuantity;

            foreach (var ingredient in Constants.SaladVegetarianIngredients)
            {
                if (!ContainsIngredient(ingredient))
                    DecoratedSalad.Ingredients.Add(ingredient);
            }
        }
    }
}
