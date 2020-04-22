using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight.register
{
    abstract class CashRegister
    {
        private Dictionary<double, Money> sharedMoney;
        private Money unsharedMoney;

        public CashRegister()
        {
            sharedMoney = new Dictionary<double, Money>();
        }

        protected Money Lookup(double value)
        {
            if(IsSharedValue(value))
            {
                if(!sharedMoney.ContainsKey(value))
                {
                    sharedMoney.Add(value, CreateNewMoney());
                }

                return sharedMoney[value];
            }
            else
            {
                if(unsharedMoney == null)
                {
                    unsharedMoney = CreateNewMoney();
                }
                return unsharedMoney;
            }  
        }

        public void CashIn(double value)
        {
            Lookup(value).TotalCashValue += value;


            Console.WriteLine($"Cash in: {value}");
        }

        public void CashOut(double value)
        {
            Money money = Lookup(value);

            if(money.TotalCashValue >= value)
            {
                money.TotalCashValue -= value;
            }
            else
            {
                Console.WriteLine($"Cash out failed for value: {value}");
            }
        }

        public double GetTotalCash()
        {
            double total = 0;

            if (unsharedMoney != null)
            {
                total += unsharedMoney.TotalCashValue;
            }

            foreach (var entry in sharedMoney)
            {
                total += entry.Value.TotalCashValue;
            }

            return total;
        }

        public abstract Money CreateNewMoney();

        public abstract bool IsSharedValue(double value);
    }
}
