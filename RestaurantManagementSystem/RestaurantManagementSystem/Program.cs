using Flyweight;
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

            Console.WriteLine("\nCash out...");
            cashier.CashOut(500, EMoneyType.Paper);
            cashier.CashOut(100, EMoneyType.Paper);

            cashier.GetTotalCash();
        }
    }
}
