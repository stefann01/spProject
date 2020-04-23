using RestaurantManagementSystem.interfaces.foods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem.models
{
    class Menu
    {
        public string Name { get; set; }
        public string Type { get; set; }

        public List<IMenuItem> MenuItems { get; set; }

        public Menu(string name, string type)
        {
            MenuItems = new List<IMenuItem>();
            Name = name;
            Type = type;
        }

        public override string ToString()
        {
            return $"Name: {Name}    |    Type: {Type}";
        }

    }
}
