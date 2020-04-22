using RestaurantManagementSystem.enums.foods;
using RestaurantManagementSystem.helpers;
using RestaurantManagementSystem.interfaces.foods;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantManagementSystem.decorator.foods
{
    public class DrinkCherrySodaDecorator : DrinkDecorator
    {
        public DrinkCherrySodaDecorator(IDrink decoratedDrink) : base(decoratedDrink)
        {
            DecoratedDrink.Type = EDrinkType.CHERRY_SODA;
            SetDish();
        }

        public override void SetDish()
        {
            DecoratedDrink.Price += Constants.DrinkCherrySodaPrice;
            DecoratedDrink.Quantity += Constants.DrinkCherrySodaQuantity;

            foreach (var ingredient in Constants.DrinkCherrySodaIngredients)
            {
                if (!ContainsIngredient(ingredient))
                    DecoratedDrink.Ingredients.Add(ingredient);
            }
        }
    }
}
