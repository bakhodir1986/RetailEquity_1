using RetailEquity.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RetailEquity.Task2.Bank
{
    public class DeutscheBank : IBank
    {
        public IEnumerable<Trade> Match(IEnumerable<Trade> trades)
        {
            return trades.Where(t => t.Type == TradeType.Option && t.SubType == TradeSubType.NewOption 
                && t.Amount > 90 && t.Amount < 120);
        }
    }
}
