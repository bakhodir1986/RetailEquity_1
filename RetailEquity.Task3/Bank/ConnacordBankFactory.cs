using System;
using System.Collections.Generic;
using System.Text;

namespace RetailEquity.Task3.Bank
{
    public class ConnacordBankFactory : BankFactory
    {
        public override IBank CreateBank()
        {
            return new ConnacordBank();
        }
    }
}
