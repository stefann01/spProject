using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantManagementSystem.interfaces.foods
{
    public interface IMenuItem
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public double Quantity { get; set; }
        public List<string> Ingredients { get; set; }
        public void SetDish(double price, double quantity, List<string> ingredients);
    }
}
