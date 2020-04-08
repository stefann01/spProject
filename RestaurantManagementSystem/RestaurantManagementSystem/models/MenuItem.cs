using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem.models
{
    abstract class MenuItem
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Type { get; set; }
        public double Quantity { get; set; }

        public List<string> Ingredients { get; set; }

        public MenuItem(string name, string type, double price = 0.0d, double quantity = 0.0d)
        {
            Name = name;
            Type = type;
            Price = price;
            Quantity = quantity;

            Ingredients = new List<string>();
        }
        public override string ToString()
        {
            return $"Name: {Name}    |    Type: {Type}    |    Price: {Price}    |    Quantity:{Quantity}";
        }
    }
}
