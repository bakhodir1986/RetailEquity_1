using RetailEquity.Model;
using RetailEquity.Task1.Bank;
using System.Collections.Generic;

namespace RetailEquity
{
    public class TradeFilter
    {
        public IEnumerable<Trade> FilterForBank(IEnumerable<Trade> trades, Bank bank)
        {
            IBank bankFactory = new BankFactory();

            return bankFactory.CreateBank(bank).Match(trades);
        }
    }
}