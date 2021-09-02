using RetailEquity.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RetailEquity.Task3.Bank
{
    public class DeutscheBank : IBank
    {
        public IEnumerable<Trade> Match(IEnumerable<Trade> trades, Country country)
        {
            return trades.Where(t => t.Type == TradeType.Option && t.SubType == TradeSubType.NewOption 
                && t.Amount > 90 && t.Amount < 120);
        }
    }
}
