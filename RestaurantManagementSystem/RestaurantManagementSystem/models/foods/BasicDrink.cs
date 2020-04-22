using RestaurantManagementSystem.enums.foods;
using RestaurantManagementSystem.helpers;
using RestaurantManagementSystem.interfaces.foods;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantManagementSystem.models.foods
{
    public class BasicDrink : IDrink
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public double Quantity { get; set; }
        public List<string> Ingredients { get; set; }
        public EDrinkType Type { get; set; }

        public BasicDrink(string name, double price = 0.0d, double quantity = 0.0d, EDrinkType type = EDrinkType.WATER)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
            Type = type;

            Ingredients = new List<string>(Constants.DrinkIngredients);
        }
        public void SetDish()
        {
            // Do nothing
        }

        public override string ToString()
        {
            var ingredients = "";
            foreach (var ingredient in Ingredients)
            {
                ingredients += ingredient + ", ";
            }
            return $"Name: {Name}    |    {Type.ToString()}    |    Price: {Price}    |    Quantity: {Quantity}    |    " + ingredients;
        }
    }
}
