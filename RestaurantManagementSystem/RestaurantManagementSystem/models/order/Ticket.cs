using RestaurantManagementSystem.interfaces.foods;
using RestaurantManagementSystem.interfaces.prototype;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace RestaurantManagementSystem.models.order
{
    [Serializable]
    public class Ticket : ITicketPrototype
    {
        public double TotalSum { get; set; }
        public Dictionary<IMenuItem, int> MenuItems { get; set; }

        public Ticket(double totalSum, Dictionary<IMenuItem, int> menuItems)
        {
            this.TotalSum = totalSum;
            this.MenuItems = menuItems;
        }

        public Ticket Clone()
        {
            using (var ms = new MemoryStream())
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(ms, this);
                ms.Position = 0;

                Ticket ticket = (Ticket)formatter.Deserialize(ms);
                return ticket;
            }
        }

        public override string ToString()
        {
            string items = "";
            foreach (var item in MenuItems)
            {
                items += $" {item.Key} {item.Value.ToString()},  \n";
            }
            return $"TotalSum: {TotalSum} \n {items}";
        }

    }
}
