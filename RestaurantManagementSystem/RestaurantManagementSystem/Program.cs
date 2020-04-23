using Flyweight;
using RestaurantManagementSystem.decorator.foods;
using RestaurantManagementSystem.enums.foods;
using RestaurantManagementSystem.helpers;
using RestaurantManagementSystem.interfaces.foods;
using RestaurantManagementSystem.iterator;
using RestaurantManagementSystem.models;
using RestaurantManagementSystem.models.foods;
using RestaurantManagementSystem.models.persons;
using System;
using System.Collections.Generic;

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

            Console.WriteLine("\n===== Testing Decorator ======");

            /* Salad */
            IDish<ESaladType> salad = new BasicDish<ESaladType>("Big Salad", 90, 300, ESaladType.BASIC);
            Console.WriteLine(salad);
            Console.WriteLine(new DishDecorator<ESaladType>(salad, ESaladType.CAESAR, Constants.SaladCaesarPrice, Constants.SaladCaesarQuantity, new List<string>(Constants.SaladCaesarIngredients)));
            Console.WriteLine(new DishDecorator<ESaladType>(salad, ESaladType.MEDITERRANEAN, Constants.SaladMediterraneanPrice, Constants.SaladMediterraneanQuantity, new List<string>(Constants.SaladMediterraneanIngredients)));
            Console.WriteLine(new DishDecorator<ESaladType>(salad, ESaladType.VEGETARIAN, Constants.SaladVegetarianPrice, Constants.SaladVegetarianQuantity, new List<string>(Constants.SaladVegetarianIngredients)));
            Console.WriteLine();

            IDish<EPizzaType> pizza = new BasicDish<EPizzaType>("Mega Pizza", 120, 400, EPizzaType.BASIC);
            Console.WriteLine(pizza);
            Console.WriteLine(new DishDecorator<EPizzaType>(pizza, EPizzaType.DIAVOLA, Constants.PizzaDiavolaPrice, Constants.PizzaDiavolaQuantity, new List<string>(Constants.PizzaDiavolaIngredients)));
            Console.WriteLine(new DishDecorator<EPizzaType>(pizza, EPizzaType.CAPRICCIOSA, Constants.PizzaCapricciosaPrice, Constants.PizzaCapricciosaQuantity, new List<string>(Constants.PizzaCapricciosaIngredients)));
            Console.WriteLine(new DishDecorator<EPizzaType>(pizza, EPizzaType.CHICKEN, Constants.PizzaChickenPrice, Constants.PizzaChickenQuantity, new List<string>(Constants.PizzaChickenIngredients)));
            Console.WriteLine();

            IDish<EDrinkType> drink = new BasicDish<EDrinkType>("Buff Drink", 30, 250, EDrinkType.WATER);
            Console.WriteLine(drink);
            Console.WriteLine(new DishDecorator<EDrinkType>(drink, EDrinkType.COLA, Constants.DrinkColaPrice, Constants.DrinkColaQuantity, new List<string>(Constants.DrinkColaIngredients)));
            Console.WriteLine(new DishDecorator<EDrinkType>(drink, EDrinkType.ORANGE_JUICE, Constants.DrinkOrangeJuicePrice, Constants.DrinkOrangeJuiceQuantity, new List<string>(Constants.DrinkOrangeJuiceIngredients)));
            Console.WriteLine(new DishDecorator<EDrinkType>(drink, EDrinkType.CHERRY_SODA, Constants.DrinkCherrySodaPrice, Constants.DrinkCherrySodaQuantity, new List<string>(Constants.DrinkCherrySodaIngredients)));
            Console.WriteLine();

            Console.WriteLine("\n===== Testing Iterator ======");
            Menu menu = new Menu("Menu1", "Daily Menu");
            menu.MenuItems.Add(salad);
            menu.MenuItems.Add(pizza);
            menu.MenuItems.Add(drink);

            IIterator iterator = menu.CreateMenuIterator();
            menu.PrintMenu(iterator);
        }
    }
}
