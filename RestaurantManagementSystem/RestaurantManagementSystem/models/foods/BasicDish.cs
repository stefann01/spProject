using RestaurantManagementSystem.enums.foods;
using RestaurantManagementSystem.helpers;
using RestaurantManagementSystem.interfaces.foods;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantManagementSystem.models.foods
{
    [Serializable]
    class BasicDish<EType> : IDish<EType>
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public double Quantity { get; set; }
        public List<string> Ingredients { get; set; }
        public EType Type { get; set; }

        public BasicDish(string name, double price, double quantity, EType type)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
            Type = type;

            Ingredients = new List<string>(Constants.SaladIngredients);
        }

        public void SetDish(double price, double quantity, List<string> ingredients)
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
