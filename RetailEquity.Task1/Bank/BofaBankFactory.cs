using System;
using System.Collections.Generic;
using System.Text;

namespace RetailEquity.Task1.Bank
{
    public class BofaBankFactory : BankFactory
    {
        public override IBank CreateBank()
        {
            return new BofaBank();
        }
    }
}
