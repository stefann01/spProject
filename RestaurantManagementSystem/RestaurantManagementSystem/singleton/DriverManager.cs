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

        public List<IMenuItem> GenerateMenuItems()
        {
            List<IMenuItem> menuItems = new List<IMenuItem>();

            menuItems.Add(new BasicDish<ESaladType>("Super Salad", 90, 300, ESaladType.BASIC));
            menuItems.Add(new SaladCaesarDecorator(new BasicDish<ESaladType>("Super Salad", 90, 300, ESaladType.BASIC)).DecoratedObj);
            menuItems.Add(new SaladMediterraneanDecorator(new BasicDish<ESaladType>("Super Salad", 90, 300, ESaladType.BASIC)).DecoratedObj);
            menuItems.Add(new SaladVegetarianDecorator(new BasicDish<ESaladType>("Super Salad", 90, 300, ESaladType.BASIC)).DecoratedObj);

            menuItems.Add(new BasicDish<EPizzaType>("Mega Pizza", 120, 400, EPizzaType.BASIC));
            menuItems.Add(new PizzaDiavolaDecorator(new BasicDish<EPizzaType>("Mega Pizza", 120, 400, EPizzaType.BASIC)).DecoratedObj);
            menuItems.Add(new PizzaCapricciosaDecorator(new BasicDish<EPizzaType>("Mega Pizza", 120, 400, EPizzaType.BASIC)).DecoratedObj);
            menuItems.Add(new PizzaChickenDecorator(new BasicDish<EPizzaType>("Mega Pizza", 120, 400, EPizzaType.BASIC)).DecoratedObj);

            menuItems.Add(new BasicDish<EDrinkType>("Buff Drink", 30, 250, EDrinkType.WATER));
            menuItems.Add(new DrinkColaDecorator(new BasicDish<EDrinkType>("Buff Drink", 30, 250, EDrinkType.WATER)).DecoratedObj);
            menuItems.Add(new DrinkOrangeJuiceDecorator(new BasicDish<EDrinkType>("Buff Drink", 30, 250, EDrinkType.WATER)).DecoratedObj);
            menuItems.Add(new DrinkCherrySodaDecorator(new BasicDish<EDrinkType>("Buff Drink", 30, 250, EDrinkType.WATER)).DecoratedObj);

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
