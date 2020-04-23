using RestaurantManagementSystem.interfaces.foods;
using RestaurantManagementSystem.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantManagementSystem.iterator
{
    class MenuIterator : IIterator
    {
        private List<IMenuItem> menuItems;
        private int position;

        public MenuIterator(List<IMenuItem> menuItems)
        {
            this.menuItems = menuItems;
            this.position = 0;
        }

        public bool HasNext()
        {
            if (position >= menuItems.Count || menuItems[position] == null)
                return false;
            return true;
        }

        public object Next()
        {
            IMenuItem menuItem = menuItems[position];
            ++position;
            return menuItem;
        }
    }
}
