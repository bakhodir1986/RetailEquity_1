using RetailEquity.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace RetailEquity.Task3.Bank
{
    public class ConnacordBank : IBank
    {
        public IEnumerable<Trade> Match(IEnumerable<Trade> trades, Country country)
        {
            return trades.Where(t => t.Type == TradeType.Future && t.Amount > 10 && t.Amount < 40);
        }
    }
}
