using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight.register
{
    class CashRegisterCoin : CashRegister
    {
        public CashRegisterCoin() : base() { }

        public override Money CreateNewMoney()
        {
            return new CoinMoney();
        }

        public override bool IsSharedValue(double value)
        {
            return CoinMoney.IsSharedValue(value);
        }
    }
}
