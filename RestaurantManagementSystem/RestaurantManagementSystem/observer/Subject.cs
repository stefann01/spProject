using RestaurantManagementSystem.helpers;
using RestaurantManagementSystem.interfaces;
using RestaurantManagementSystem.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantManagementSystem
{
    class Subject : ISubject
    {
        private List<Observer> observers = new List<Observer>();
        private Order order = null;
        public string OrderStatus
        {
            get
            {
                return order.Status;
            }
            set
            {
                if (value != null)
                {
                    order.Status = value;
                    Notify();
                }
            }
        }

        public Subject(Order order)
        {
            this.order = order;
        }

        public void Register(Observer observer)
        {
            if (!observers.Contains(observer))
            {
                observers.Add(observer);
            }
        }

        public void Unregister(Observer observer)
        {
            if (observers.Contains(observer))
            {
                observers.Remove(observer);
            }
        }

        public void Notify()
        {
            foreach (Observer observer in observers)
            {
                observer.Update(this.OrderStatus);
            }
        }
    }
}
