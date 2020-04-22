using Flyweight;
using RestaurantManagementSystem.helpers;
using RestaurantManagementSystem.models;
using RestaurantManagementSystem.models.persons;
using System;

namespace RestaurantManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== Testing Flyweight ======");

            Cashier cashier = new Cashier(1, "Joe", "Doe", 3000);

            Console.WriteLine(cashier);

            Console.WriteLine("Cash in...");
            cashier.CashIn(0.5, EMoneyType.Coin);
            cashier.CashIn(100, EMoneyType.Paper);
            cashier.CashIn(445, EMoneyType.Card);

            cashier.GetTotalCash();

            Console.WriteLine("Cash out...");
            cashier.CashOut(500, EMoneyType.Paper);
            cashier.CashOut(100, EMoneyType.Paper);

            cashier.GetTotalCash();

            Console.WriteLine("\n===== Testing Observer ======");
            Customer customer = new Customer(1, "Customer1", "Customer", 4000);
            Console.WriteLine(customer);

            Order order = new Order(1, customer);
            Console.WriteLine(order);

            Subject subject = new Subject(order);
            Observer observer = new Observer(customer);

            Console.WriteLine("Register observers...");
            subject.Register(observer);

            Console.WriteLine("Complete order...");
            subject.OrderStatus = Constants.CompletedStatus;
        }
    }
}
