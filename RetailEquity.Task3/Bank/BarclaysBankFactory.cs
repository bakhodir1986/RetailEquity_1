using System;
using System.Collections.Generic;
using System.Text;

namespace RetailEquity.Task3.Bank
{
    public class BarclaysBankFactory : BankFactory
    {
        public override IBank CreateBank()
        {
            return new BarclaysBank();
        }
    }
}
