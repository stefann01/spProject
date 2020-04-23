using RestaurantManagementSystem.models.order;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantManagementSystem.interfaces.prototype
{
    public interface ITicketPrototype
    {
        public Ticket Clone(); 
    }
}
