using RetailEquity.Filters;
using RetailEquity.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RetailEquity.Task1.Bank
{
    public class UKDeutscheBank : IFilter
    {
        public IEnumerable<Trade> Match(IEnumerable<Trade> trades)
        {
            return trades.Where(t => t.Type == TradeType.Option && t.SubType == TradeSubType.NewOption
                            && t.Amount > 90 && t.Amount < 120);
        }
    }
}
