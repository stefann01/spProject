using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantManagementSystem.interfaces
{
    interface ISubject
    {
        void Register(Observer observer);
        void Unregister(Observer observer);
        void Notify();
    }
}
