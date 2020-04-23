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
        static void ChooseOrderMenu(OrderInvoker invoker, Menu menu)
        {
            IIterator iterator = menu.CreateMenuIterator();
            menu.PrintMenu(iterator);
            while (true)
            {
                Console.WriteLine("Enter option: ");
                int option = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Enter amount: ");
                int amount = Int32.Parse(Console.ReadLine());

                if (option < menu.MenuItems.Count && option-1 > 0)
                {
                    invoker.DoOrder(menu.MenuItems[option - 1], amount);
                    Console.Clear();
                    break;
                }
                Console.WriteLine("Please enter a valid option.");

            }
        }

        static void Main(string[] args)
        {
            List<Customer> customers = DriverManager.GetInstance().GenerateCustomers();
            Cashier cashier = DriverManager.GetInstance().GenerateCashier();
            Menu menu = new Menu("Menu", "Daily Menu");
            menu.MenuItems = DriverManager.GetInstance().GenerateMenuItems();
            Subject subject;
            Observer observer;

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
                    subject = new Subject(invoker.GetOrder());
                    observer = new Observer(currentCustomer);
                    subject.Register(observer);
                    break;
                }
                Console.WriteLine("Please choose a valid customer!");
            }



            while (true)
            {
                Console.WriteLine("===== Menu =====");
                Console.WriteLine("0. Exit");
                Console.WriteLine("1. Show Menu");
                Console.WriteLine("2. Order");
                Console.WriteLine("3. Pay");
                Console.WriteLine("4. Checkout");
                Console.WriteLine("5. Display order");
                Console.WriteLine("Enter option: ");

                int option = Int32.Parse(Console.ReadLine());
                Console.Clear();

                switch (option)
                {
                    case 1:
                        IIterator iterator = menu.CreateMenuIterator();
                        menu.PrintMenu(iterator);
                        break;
                    case 2:
                        ChooseOrderMenu(invoker, menu);
                        subject.OrderStatus = Constants.InProgressStatus;
                        break;
                    case 3:
                        if (subject.OrderStatus == Constants.InProgressStatus)
                        {
                            double sumToPay = invoker.GetOrder().TotalSum;
                            if (currentCustomer.Budget >= sumToPay)
                            {
                                cashier.GetTotalCash();
                                Console.WriteLine("Cash in...");
                                cashier.CashIn(sumToPay, EMoneyType.Card);
                                currentCustomer.Budget -= sumToPay;
                                cashier.GetTotalCash();
                                subject.OrderStatus = Constants.PayedStatus;
                            }
                            else
                            {
                                Console.WriteLine("No enough money!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Cannot pay before you order.");
                        }
                        break;
                    case 4:
                        if (subject.OrderStatus == Constants.PayedStatus)
                        {
                            Order customerOrder = invoker.GetOrder();
                            Ticket ticket = new Ticket(customerOrder.TotalSum, customerOrder.MenuItems);
                            Ticket customerTicket = ticket.Clone();
                            Ticket restaurantTicket = ticket.Clone();
                            Console.WriteLine($"Customer ticket: {customerTicket}");
                            Console.WriteLine($"Restaurant ticket: {restaurantTicket}");
                            invoker.DeleteOrder();
                            subject.OrderStatus = Constants.CompletedStatus;
                        }
                        else
                        {
                            Console.WriteLine("You cannot checkout before you pay.");
                        }
                        break;
                    case 5:
                        Order order = invoker.GetOrder();
                        Console.WriteLine(order);
                        break;
                    case 0:
                        return;
                    default:
                        break;
                }
            }
        }
    }
}
