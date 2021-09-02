using RetailEquity.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace RetailEquity.Task3.Bank
{
    public interface IBank
    {
        IEnumerable<Trade> Match(IEnumerable<Trade> trades, Country country);
    }
}
