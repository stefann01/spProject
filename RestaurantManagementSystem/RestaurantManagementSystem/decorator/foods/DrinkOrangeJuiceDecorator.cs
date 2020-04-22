using RestaurantManagementSystem.enums.foods;
using RestaurantManagementSystem.helpers;
using RestaurantManagementSystem.interfaces.foods;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantManagementSystem.decorator.foods
{
    public class DrinkOrangeJuiceDecorator : DrinkDecorator
    {
        public DrinkOrangeJuiceDecorator(IDrink decoratedDrink) : base(decoratedDrink)
        {
            DecoratedDrink.Type = EDrinkType.ORANGE_JUICE;
            SetDish();
        }

        public override void SetDish()
        {
            DecoratedDrink.Price += Constants.DrinkOrangeJuicePrice;
            DecoratedDrink.Quantity += Constants.DrinkOrangeJuiceQuantity;

            foreach (var ingredient in Constants.DrinkOrangeJuiceIngredients)
            {
                if (!ContainsIngredient(ingredient))
                    DecoratedDrink.Ingredients.Add(ingredient);
            }
        }
    }
}
