using RestaurantManagementSystem.enums.foods;
using RestaurantManagementSystem.helpers;
using RestaurantManagementSystem.interfaces.foods;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantManagementSystem.decorator.foods
{
    class PizzaDiavolaDecorator : PizzaDecorator
    {
        public PizzaDiavolaDecorator(IPizza decoratedPizza) : base(decoratedPizza)
        {
            DecoratedPizza.Type = EPizzaType.DIAVOLA;
            SetDish();
        }

        public override void SetDish()
        {
            DecoratedPizza.Price += Constants.PizzaDiavolaPrice;
            DecoratedPizza.Quantity += Constants.PizzaDiavolaQuantity;

            foreach (var ingredient in Constants.PizzaDiavolaIngredients)
            {
                if (!ContainsIngredient(ingredient))
                    DecoratedPizza.Ingredients.Add(ingredient);
            }
        }
    }
}
