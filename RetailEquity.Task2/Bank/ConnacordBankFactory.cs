using System;
using System.Collections.Generic;
using System.Text;

namespace RetailEquity.Task2.Bank
{
    public class ConnacordBankFactory : BankFactory
    {
        public override IBank CreateBank()
        {
            return new ConnacordBank();
        }
    }
}
