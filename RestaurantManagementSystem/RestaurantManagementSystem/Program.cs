using Flyweight;
using RestaurantManagementSystem.decorator.foods;
using RestaurantManagementSystem.decorator.foods.pizza;
using RestaurantManagementSystem.decorator.foods.salad;
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
                int option;
                int amount;
                if (int.TryParse(Console.ReadLine(), out option))
                {
                    Console.WriteLine("Enter amount: ");
                    if (int.TryParse(Console.ReadLine(), out amount))
                    {
                        if (option < menu.MenuItems.Count && option - 1 >= 0)
                        {
                            invoker.DoOrder(menu.MenuItems[option - 1], amount);
                            Console.Clear();
                            break;
                        }
                        Console.WriteLine("Please enter a valid option.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid amount");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid option");
                }

            }
        }

        static void Pay(OrderInvoker invoker, Customer customer, Cashier cashier, Subject subject)
        {
            if (subject.OrderStatus == Constants.PayedStatus || subject.OrderStatus == Constants.CompletedStatus)
            {
                Console.WriteLine("You already paid.");
            }
            else
            {
                double sumToPay = invoker.GetOrder().TotalSum;
                if (customer.Budget >= sumToPay)
                {
                    IMenuItem menuItem = menu.MenuItems[option - 1];
                    invoker.DoOrder(menuItem, amount);

                    Console.WriteLine("Do you want extra ingredients?");
                    Console.WriteLine("1. Yes");
                    Console.WriteLine("2. No");
                    int extraIngredientsOption;

                    if (int.TryParse(Console.ReadLine(), out extraIngredientsOption))
                    {
                        Console.Clear();
                        if (extraIngredientsOption == 1)
                        {
                            ChooseExtraIngredients(invoker, menuItem);
                        }

                        Console.Clear();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid option.");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid option.");
                }

            }
        }

        static void ChooseExtraIngredients(OrderInvoker invoker, IMenuItem menuItem)
        {
            IDish<ESaladType> salad = menuItem as IDish<ESaladType>;
            IDish<EPizzaType> pizza = menuItem as IDish<EPizzaType>;
            IDish<EDrinkType> drink = menuItem as IDish<EDrinkType>;

            if (salad != null && pizza != null && drink != null)
                return;

            while (true)
            {
                int option;
                bool exit = false;

                Console.WriteLine(menuItem);
                Console.WriteLine();
                Console.WriteLine("Extra ingredients:");
                if (salad != null)
                {
                    Console.WriteLine("1. Mozzarella");
                    Console.WriteLine("2. Dressing");
                    Console.WriteLine();
                    Console.WriteLine("0. Exit");
                    if (int.TryParse(Console.ReadLine(), out option))
                    {
                        switch (option)
                        {
                            case 1:
                                new SaladExtraMozzarellaDecorator(salad);
                                break;
                            case 2:
                                new SaladExtraSpicyDressingDecorator(salad);
                                break;
                            case 0:
                                exit = true;
                                break;

                            default:
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid option!");
                    }

                }
                else if (pizza != null)
                {
                    Console.WriteLine("1. Bacon");
                    Console.WriteLine("3. Tomatoes");
                    Console.WriteLine();
                    Console.WriteLine("0. Exit");
                    if (int.TryParse(Console.ReadLine(), out option))
                    {
                        switch (option)
                        {
                            case 1:
                                new PizzaExtraBaconDecorator(pizza);
                                break;
                            case 2:
                                new PizzaExtraTomatoesDecorator(pizza);
                                break;
                            case 0:
                                exit = true;
                                break;

                            default:
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid option!");
                    }
                }
                else if (drink != null)
                {
                    Console.WriteLine("1. Lemon");
                    Console.WriteLine("2. Sugar");
                    Console.WriteLine();
                    Console.WriteLine("0. Exit");
                    if (int.TryParse(Console.ReadLine(), out option))
                    {
                        switch (option)
                        {
                            case 1:
                                new DrinkExtraLemonDecorator(drink);
                                break;
                            case 2:
                                new DrinkExtraSugarDecorator(drink);
                                break;
                            case 0:
                                exit = true;
                                break;

                            default:
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid option!");
                    }
                }
                Console.Clear();

                if (exit == true)
                {
                    break;
                }
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

                int customerOption;
                if (int.TryParse(Console.ReadLine(), out customerOption))
                {


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
                else
                {
                    Console.WriteLine("Invalid option");
                }
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

                int option;
                if (int.TryParse(Console.ReadLine(), out option))
                {
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
                            Pay(invoker, currentCustomer, cashier, subject);
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
                else
                {
                    Console.WriteLine("Invalid option");
                }
            }
        }
    }
}
