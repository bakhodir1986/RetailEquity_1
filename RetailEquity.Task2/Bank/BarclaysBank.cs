using RetailEquity.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace RetailEquity.Task2.Bank
{
    public class BarclaysBank : IBank
    {
        public IEnumerable<Trade> Match(IEnumerable<Trade> trades)
        {
            return trades.Where(t => t.Type == TradeType.Option && t.SubType == TradeSubType.NyOption && t.Amount > 50);
        }
    }
}
