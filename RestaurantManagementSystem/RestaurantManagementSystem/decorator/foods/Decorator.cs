using RestaurantManagementSystem.interfaces.foods;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace RestaurantManagementSystem.decorator.foods
{
    [Serializable]

    public class Decorator<EType> : IDish<EType>
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public double Quantity { get; set; }
        public List<string> Ingredients { get; set; }
      
        public EType Type { get; set; }
        public IDish<EType> DecoratedObj { get; set; }
        EType IDish<EType>.Type { get; set; }

        public Decorator() {}

        public Decorator(IDish<EType> decoratedObj)
        {
            DecoratedObj = decoratedObj;
        }

        public Decorator(IDish<EType> decoratedObj, EType type, double price, double quantity, List<string> ingredients)
        {
            Type = type;
            Quantity += quantity;
            Price += price;

            DecoratedObj = decoratedObj;
            DecoratedObj.Type = type;
            SetDish(price, quantity, ingredients);
        }

        public Decorator(IDish<EType> decoratedObj, double price, double quantity, List<string> ingredients)
        {
            Quantity += quantity;
            Price += price;

            DecoratedObj = decoratedObj;
            SetDish(price, quantity, ingredients);
        }

        protected bool ContainsIngredient(string ingredient)
        {
            if (DecoratedObj.Ingredients.Contains(ingredient))
            {
                return true;
            }
            return false;
        }

        public void SetDish(double price, double quantity, List<string> ingredients)
        {
            DecoratedObj.Price += price;
            DecoratedObj.Quantity += quantity;

            foreach (var ingredient in ingredients)
            {
                if (!ContainsIngredient(ingredient))
                {
                    DecoratedObj.Ingredients.Add(ingredient);

                    if (Ingredients == null)
                    {
                        Ingredients = new List<string>();
                    }
                    Ingredients.Add(ingredient);
                }
            }
        }

        public override string ToString()
        {
            return DecoratedObj.ToString();
        }
    }
}
