using Flyweight;
using Flyweight.register;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem.models.persons
{
    class Cashier : Employee
    {
        private CashRegister cashRegisterCoin;
        private CashRegister cashRegisterPaper;
        private CashRegister cashRegisterCard; 

        public Cashier(int id, string firstName, string lastName, double salary) :
            base(id, firstName, lastName, salary)
        {
            cashRegisterCoin = new CashRegisterCoin();
            cashRegisterPaper = new CashRegisterPaper();
            cashRegisterCard = new CashRegisterCard();
        }

        public override string ToString()
        {
            return $"Cashier   |   FirstName: {FirstName}   |   LastName: {LastName}   |   Salary: {Salary}";
        }

        public void CashIn(double value, EMoneyType type)
        {
            switch (type)
            {
                case EMoneyType.Card:
                    cashRegisterCard.CashIn(value);
                    break;

                case EMoneyType.Coin:
                    cashRegisterCoin.CashIn(value);
                    break;

                case EMoneyType.Paper:
                    cashRegisterPaper.CashIn(value);
                    break;
            }
        }

        public void CashOut(double value, EMoneyType type)
        {
            switch (type)
            {
                case EMoneyType.Card:
                    cashRegisterCard.CashOut(value);
                    break;

                case EMoneyType.Coin:
                    cashRegisterCoin.CashOut(value);
                    break;

                case EMoneyType.Paper:
                    cashRegisterPaper.CashOut(value);
                    break;
            }
        }

        public void GetTotalCash()
        {
            double total = 0;

            total += cashRegisterCard.GetTotalCash();
            total += cashRegisterCoin.GetTotalCash();
            total += cashRegisterPaper.GetTotalCash();

            Console.WriteLine($"Total cash: {total}");
        }
    }
}

