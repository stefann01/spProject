using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight.register
{
    class CashRegisterCard : CashRegister
    {
        public CashRegisterCard() : base() { }

        public override Money CreateNewMoney()
        {
            return new CardMoney();
        }

        public override bool IsSharedValue(double value)
        {
            return CardMoney.IsSharedValue(value);
        }
    }
}
