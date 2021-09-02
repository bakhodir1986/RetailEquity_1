using RetailEquity.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace RetailEquity.Task3.Bank
{
    public class BarclaysBank : IBank
    {
        public IEnumerable<Trade> Match(IEnumerable<Trade> trades, Country country)
        {
            if (country == Country.England)
            {
                return trades.Where(t => t.Type == TradeType.Future && t.Amount > 100);
            }

            return trades.Where(t => t.Type == TradeType.Option && t.SubType == TradeSubType.NyOption && t.Amount > 50);
        }
    }
}
