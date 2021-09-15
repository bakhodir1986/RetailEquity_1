using System;
using System.Collections.Generic;
using System.Text;

namespace RetailEquity.Task1.Bank
{
    public interface IBank
    {
        public IFilter CreateBank(RetailEquity.Bank bank);
    }
}
