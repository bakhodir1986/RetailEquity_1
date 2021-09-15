using RetailEquity.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace RetailEquity.Task1.Bank
{
    public class BarclaysBank : IFilter
    {
        public IEnumerable<Trade> Match(IEnumerable<Trade> trades)
        {
            return trades.Where(t => t.Type == TradeType.Option && t.SubType == TradeSubType.NyOption && t.Amount > 50);
        }
    }
}
