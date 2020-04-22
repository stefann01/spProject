using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
    abstract class Money
    {
        const double defaultCacheValue = 0;

        public double TotalCashValue { get; set; }

        public Money()
        {
            TotalCashValue = defaultCacheValue;
        }

        public abstract EMoneyType GetMoneyType();
    }
}
