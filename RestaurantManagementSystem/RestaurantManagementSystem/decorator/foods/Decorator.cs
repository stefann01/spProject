﻿using RestaurantManagementSystem.interfaces.foods;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace RestaurantManagementSystem.decorator.foods
{
    public class Decorator<EType> : IDish<EType>
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public double Quantity { get; set; }
        public List<string> Ingredients { get; set; }
        EType IDish<EType>.Type { get; set; }

        protected IDish<EType> DecoratedObj { get; set; }

        public Decorator() {}

        public Decorator(IDish<EType> decoratedObj)
        {
            DecoratedObj = decoratedObj;
        }

        public Decorator(IDish<EType> decoratedObj, EType type, double price, double quantity, List<string> ingredients)
        {
            DecoratedObj = decoratedObj;
            DecoratedObj.Type = type;
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
                    DecoratedObj.Ingredients.Add(ingredient);
            }
        }

        public override string ToString()
        {
            return DecoratedObj.ToString();
        }
    }
}
