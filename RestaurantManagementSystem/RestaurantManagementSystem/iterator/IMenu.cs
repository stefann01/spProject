using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantManagementSystem.iterator
{
    interface IMenu
    {
        IIterator CreateMenuIterator();
    }
}
