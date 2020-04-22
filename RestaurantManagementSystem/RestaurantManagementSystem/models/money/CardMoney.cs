using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
    class CardMoney : Money
    {
        public CardMoney() : base() { }

        public override EMoneyType GetMoneyType()
        {
            return EMoneyType.Card;
        }

        public static bool IsSharedValue(double value)
        {
            return false;
        }
    }
}
