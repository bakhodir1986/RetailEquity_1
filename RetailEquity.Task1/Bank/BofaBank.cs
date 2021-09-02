using RetailEquity.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace RetailEquity.Task1.Bank
{
    public class BofaBank : IBank
    {
        public IEnumerable<Trade> Match(IEnumerable<Trade> trades)
        {
            return trades.Where(t => t.Amount > 70);
        }
    }
}
