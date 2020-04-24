using RestaurantManagementSystem.interfaces.foods;
using RestaurantManagementSystem.iterator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem.models
{
    class Menu : IMenu
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

        public IIterator CreateMenuIterator()
        {
            return new MenuIterator(MenuItems);
        }

        public void PrintMenu(IIterator iterator)
        {
            Console.WriteLine("Menu");
            Console.WriteLine("**************************************");
            Console.WriteLine();

            int counter = 0;

            while (iterator.HasNext())
            {
                Console.WriteLine($"{++counter} {iterator.Next()}");
            }
        }

        public override string ToString()
        {
            return $"Name: {Name}    |    Type: {Type}";
        }
    }
}
