using RestaurantManagementSystem.enums.foods;
using RestaurantManagementSystem.helpers;
using RestaurantManagementSystem.interfaces.foods;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantManagementSystem.decorator.foods
{
    public class DrinkColaDecorator : DrinkDecorator
    {
        public DrinkColaDecorator(IDrink decoratedDrink) : base(decoratedDrink)
        {
            DecoratedDrink.Type = EDrinkType.COLA;
            SetDish();
        }

        public override void SetDish()
        {
            DecoratedDrink.Price += Constants.DrinkColaPrice;
            DecoratedDrink.Quantity += Constants.DrinkColaQuantity;

            foreach (var ingredient in Constants.DrinkColaIngredients)
            {
                if (!ContainsIngredient(ingredient))
                    DecoratedDrink.Ingredients.Add(ingredient);
            }
        }
    }
}
