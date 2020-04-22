using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
    class CoinMoney : Money
    {
        private static List<double> sharedValues = new List<double>() { 0.01, 0.05, 0.1, 0.5 };

        public CoinMoney() : base() { }

        public override EMoneyType GetMoneyType()
        {
            return EMoneyType.Coin;
        }

        public static bool IsSharedValue(double value)
        {
            return sharedValues.Contains(value);
        }
    }
}
