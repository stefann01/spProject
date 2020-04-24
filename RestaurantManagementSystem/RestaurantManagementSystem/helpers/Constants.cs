using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem.helpers
{
    public static class Constants
    {
        public const double DefaultTotalSumValue = 0;
        public const string DefaultStatus = "Uninitialized";
        public const string InProgressStatus = "Progress";
        public const string PayedStatus = "Paid";
        public const string CompletedStatus = "Completed";

        /*=====< Foods >=====*/

        /* Salads */
        public static readonly string[] SaladIngredients = { "Lettuce", "Cucumber" };
        
        public const double SaladCaesarPrice = 50;
        public const double SaladCaesarQuantity = 100;
        public static readonly string[] SaladCaesarIngredients = { "Parmesan cheese", "Tomato" };

        public const double SaladMediterraneanPrice = 40;
        public const double SaladMediterraneanQuantity = 100;
        public static readonly string[] SaladMediterraneanIngredients = { "Feta cheese", "Olives" };

        public const double SaladVegetarianPrice = 30;
        public const double SaladVegetarianQuantity = 100;
        public static readonly string[] SaladVegetarianIngredients = { "Carrot", "Corn" };

        public const double SaladExtraMozzarellaPrice = 10;
        public const double SaladExtraMozzarellaQuantity = 50;
        public static readonly string[] SaladExtraMozzarellaIngredients = { "Mozzarella" };

        public const double SaladExtraSpicyDressingPrice = 5;
        public const double SaladExtraSpicyDressingQuantity = 30;
        public static readonly string[] SaladExtraSpicyDressingIngredients = { "Spicy dressing" };

        /* Pizzas */
        public static readonly string[] PizzaIngredients = { "Flour", "Tomato souce" };

        public const double PizzaDiavolaPrice = 60;
        public const double PizzaDiavolaQuantity = 150;
        public static readonly string[] PizzaDiavolaIngredients = { "Pepperoni", "Jalapenos" };

        public const double PizzaCapricciosaPrice = 40;
        public const double PizzaCapricciosaQuantity = 150;
        public static readonly string[] PizzaCapricciosaIngredients = { "Ham", "Mushrooms" };

        public const double PizzaChickenPrice = 50;
        public const double PizzaChickenQuantity = 150;
        public static readonly string[] PizzaChickenIngredients = { "Chicken", "Olives" };

        public const double PizzaExtraBaconPrice = 40;
        public const double PizzaExtraBaconQuantity = 50;
        public static readonly string[] PizzaExtraBaconIngredients = { "Bacon" };

        public const double PizzaExtraTomatoesPrice = 20;
        public const double PizzaExtraTomatoesQuantity = 50;
        public static readonly string[] PizzaExtraTomatoesIngredients = { "Tomatoes" };

        /* Drinks */
        public static readonly string[] DrinkIngredients = { "Water" };

        public const double DrinkColaPrice = 30;
        public const double DrinkColaQuantity = 0;
        public static readonly string[] DrinkColaIngredients = { "Sugar", "Cola flavour" };

        public const double DrinkOrangeJuicePrice = 50;
        public const double DrinkOrangeJuiceQuantity = 0;
        public static readonly string[] DrinkOrangeJuiceIngredients = { "Oranges" };

        public const double DrinkCherrySodaPrice = 40;
        public const double DrinkCherrySodaQuantity = 0;
        public static readonly string[] DrinkCherrySodaIngredients = { "Sugar", "Cherry 0.001%" };

        public const double DrinkExtraSugarPrice = 5;
        public const double DrinkExtraSugarQuantity = 10;
        public static readonly string[] DrinkExtraSugarIngredients = { "Sugar" };

        public const double DrinkExtraLemonPrice = 10;
        public const double DrinkExtraLemonQuantity = 15;
        public static readonly string[] DrinkExtraLemonIngredients = { "Lemon" };
    }
}
