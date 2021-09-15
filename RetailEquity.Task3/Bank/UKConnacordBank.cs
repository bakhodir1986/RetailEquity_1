using RetailEquity.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace RetailEquity.Task1.Bank
{
    public class UKConnacordBank : IFilter
    {
        public IEnumerable<Trade> Match(IEnumerable<Trade> trades)
        {
            return trades.Where(t => t.Type == TradeType.Future && t.Amount > 10 && t.Amount < 40);
        }
    }
}
