using Flyweight;
using RestaurantManagementSystem.decorator.foods;
using RestaurantManagementSystem.decorator.foods.pizza;
using RestaurantManagementSystem.decorator.foods.salads;
using RestaurantManagementSystem.enums.foods;
using RestaurantManagementSystem.helpers;
using RestaurantManagementSystem.interfaces.foods;
using RestaurantManagementSystem.iterator;
using RestaurantManagementSystem.models;
using RestaurantManagementSystem.models.foods;
using RestaurantManagementSystem.models.order;
using RestaurantManagementSystem.models.persons;
using RestaurantManagementSystem.singleton;
using System;
using System.Collections.Generic;

namespace RestaurantManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers = DriverManager.GetInstance().GenerateCustomers();
            Cashier cashier = DriverManager.GetInstance().GenerateCashier();
            Menu menu = new Menu("Menu", "Daily Menu");
            menu.MenuItems = DriverManager.GetInstance().GenerateMenuItems();


            Customer currentCustomer = null;
            OrderInvoker invoker = null;
            Console.WriteLine("Choose customer: ");

            for (int i = 0; i < customers.Count; i++)
            {
                Console.WriteLine($"{i} {customers[i]}");
            }
            while (true)
            {
                int customerOption = Int32.Parse(Console.ReadLine());

                if (customerOption <= customers.Count)
                {
                    currentCustomer = customers[customerOption];
                    invoker = new OrderInvoker(currentCustomer);
                    break;
                }
                Console.WriteLine("Please choose a valid customer!");
            }

            Console.WriteLine("===== Menu =====");
            Console.WriteLine("1. Show Menu");
            Console.WriteLine("2. Order");
            Console.WriteLine("3. Pay");
            Console.WriteLine("4. Check order status");
            Console.WriteLine("5. Show ticket");
            Console.WriteLine("6. Exit");

            while (true)
            {
                Console.WriteLine("Enter option: ");

                int option = Int32.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        IIterator iterator = menu.CreateMenuIterator();
                        menu.PrintMenu(iterator);
                        break;
                    case 2:
                        invoker.DoOrder(menu.MenuItems[0], 3);
                        invoker.DoOrder(menu.MenuItems[1], 2);
                        break;
                    case 3:
                        double sumToPay = invoker.GetOrder().TotalSum;
                        if (currentCustomer.Budget >= sumToPay)
                        {
                            cashier.GetTotalCash();
                            Console.WriteLine("Cash in...");
                            cashier.CashIn(sumToPay, EMoneyType.Card);
                            currentCustomer.Budget -= sumToPay;
                            cashier.GetTotalCash();
                        }
                        else
                        {
                            Console.WriteLine("No enough money!");
                        }
                        break;
                    case 4:
                        Subject subject = new Subject(invoker.GetOrder());
                        Observer observer = new Observer(currentCustomer);

                        Console.WriteLine("Register observers...");
                        subject.Register(observer);

                        Console.WriteLine("Complete order...");
                        subject.OrderStatus = Constants.CompletedStatus;
                        break;
                    case 5:
                        Order customerOrder = invoker.GetOrder();
                        Ticket ticket = new Ticket(customerOrder.TotalSum, customerOrder.MenuItems);
                        Ticket customerTicket = ticket.Clone();
                        Ticket restaurantTicket = ticket.Clone();
                        Console.WriteLine($"Customer ticket: {customerTicket}");
                        Console.WriteLine($"Restaurant ticket: {restaurantTicket}");
                        invoker.DeleteOrder();
                        break;
                    case 6:
                        return;
                    default:
                        break;
                }
            }
        }
    }
}
