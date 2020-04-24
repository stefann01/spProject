using RestaurantManagementSystem.decorator.foods.pizza;
using RestaurantManagementSystem.decorator.foods.salads;
using RestaurantManagementSystem.enums.foods;
using RestaurantManagementSystem.interfaces.foods;
using RestaurantManagementSystem.models.foods;
using RestaurantManagementSystem.models.persons;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantManagementSystem.singleton
{
    class DriverManager
    {
        private static DriverManager instance;


        private DriverManager()
        {

        }

        public static DriverManager GetInstance()
        {
            if (instance!=null)
            {
                return instance;
            }
            return new DriverManager();
        }

        private BasicDish<Type> CreateBasicDish<Type>(string name, double price, double quantity, Type def)
        {
            return new BasicDish<Type>("Super Salad", 90, 300, def);
        }

        public List<IMenuItem> GenerateMenuItems()
        {
            List<IMenuItem> menuItems = new List<IMenuItem>();

            menuItems.Add(CreateBasicDish("Basic Salad", 90, 300, ESaladType.BASIC));
            menuItems.Add(new SaladCaesarDecorator(CreateBasicDish("Salad Caesar", 90, 300, ESaladType.BASIC)).DecoratedObj);
            menuItems.Add(new SaladMediterraneanDecorator(CreateBasicDish("Salad Mediterranean", 90, 300, ESaladType.BASIC)).DecoratedObj);
            menuItems.Add(new SaladVegetarianDecorator(CreateBasicDish("Salad Vegetarian", 90, 300, ESaladType.BASIC)).DecoratedObj);

            menuItems.Add(CreateBasicDish("Basic Pizza", 120, 400, EPizzaType.BASIC));
            menuItems.Add(new PizzaDiavolaDecorator(CreateBasicDish("Pizza Diavola", 120, 400, EPizzaType.BASIC)).DecoratedObj);
            menuItems.Add(new PizzaCapricciosaDecorator(CreateBasicDish("Pizza Capricciosa", 120, 400, EPizzaType.BASIC)).DecoratedObj);
            menuItems.Add(new PizzaChickenDecorator(CreateBasicDish("Pizza Chicken", 120, 400, EPizzaType.BASIC)).DecoratedObj);

            menuItems.Add(CreateBasicDish("Water", 30, 250, EDrinkType.WATER));
            menuItems.Add(new DrinkColaDecorator(CreateBasicDish("Cola", 30, 250, EDrinkType.WATER)).DecoratedObj);
            menuItems.Add(new DrinkOrangeJuiceDecorator(CreateBasicDish("Orange Juice", 30, 250, EDrinkType.WATER)).DecoratedObj);
            menuItems.Add(new DrinkCherrySodaDecorator(CreateBasicDish("Cherry Soda", 30, 250, EDrinkType.WATER)).DecoratedObj);

            return menuItems;
        }

        public List<Customer> GenerateCustomers()
        {
            List<Customer> customers = new List<Customer>();

            customers.Add(new Customer("Mares", "Stefan", 1000));
            customers.Add(new Customer("Stefi", "Man", 5000));
            customers.Add(new Customer("Cristi", "Ilie", 3000));

            return customers;
        }
    
        public Cashier GenerateCashier()
        {
            return new Cashier("Joe", "Doe", 500);
        }
    }
}
