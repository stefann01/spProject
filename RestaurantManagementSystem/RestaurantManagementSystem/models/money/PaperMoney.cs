using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
    class PaperMoney : Money
    {
        private static List<double> sharedValues = new List<double>() { 1, 5, 10, 50, 100, 200, 500 };

        public PaperMoney() : base() { }

        public override EMoneyType GetMoneyType()
        {
            return EMoneyType.Paper;
        }

        public static bool IsSharedValue(double value)
        {
            return sharedValues.Contains(value);
        }
    }
}
