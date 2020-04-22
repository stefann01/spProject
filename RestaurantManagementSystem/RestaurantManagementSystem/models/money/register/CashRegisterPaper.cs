using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight.register
{
    class CashRegisterPaper : CashRegister
    {
        public CashRegisterPaper() : base() { }

        public override Money CreateNewMoney()
        {
            return new PaperMoney();
        }

        public override bool IsSharedValue(double value)
        {
            return PaperMoney.IsSharedValue(value);
        }
    }
}
