using RetailEquity.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace RetailEquity.Task2.Bank
{
    public interface IBank
    {
        IEnumerable<Trade> Match(IEnumerable<Trade> trades);
    }
}
