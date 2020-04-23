using RestaurantManagementSystem.interfaces.foods;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantManagementSystem.decorator.foods
{
    class DishDecorator<EType> : Decorator<EType>
    {
        public DishDecorator(IDish<EType> decoratedObj, EType type, double price, double quantity, List<string> ingredients) : 
            base(decoratedObj)
        {
            DecoratedObj.Type = type;
            SetDish(price, quantity, ingredients);
        }

        public override void SetDish(double price, double quantity, List<string> ingredients)
        {
            DecoratedObj.Price += price;
            DecoratedObj.Quantity += quantity;

            foreach (var ingredient in ingredients)
            {
                if (!ContainsIngredient(ingredient))
                    DecoratedObj.Ingredients.Add(ingredient);
            }
        }
    }
}
