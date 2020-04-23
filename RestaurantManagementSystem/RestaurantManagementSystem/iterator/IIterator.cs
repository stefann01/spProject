using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantManagementSystem.iterator
{
    interface IIterator
    {
        bool HasNext();
        object Next();
    }
}
