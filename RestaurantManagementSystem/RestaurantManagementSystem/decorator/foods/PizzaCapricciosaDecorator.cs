using RestaurantManagementSystem.enums.foods;
using RestaurantManagementSystem.helpers;
using RestaurantManagementSystem.interfaces.foods;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantManagementSystem.decorator.foods
{
    class PizzaCapricciosaDecorator : PizzaDecorator
    {
        public PizzaCapricciosaDecorator(IPizza decoratedPizza) : base(decoratedPizza)
        {
            DecoratedPizza.Type = EPizzaType.CAPRICCIOSA;
            SetDish();
        }

        public override void SetDish()
        {
            DecoratedPizza.Price += Constants.PizzaCapricciosaPrice;
            DecoratedPizza.Quantity += Constants.PizzaCapricciosaQuantity;

            foreach (var ingredient in Constants.PizzaCapricciosaIngredients)
            {
                if (!ContainsIngredient(ingredient))
                    DecoratedPizza.Ingredients.Add(ingredient);
            }
        }
    }
}
