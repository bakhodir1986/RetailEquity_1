using RetailEquity.Model;
using RetailEquity.Task1.Bank;
using RetailEquity.Task3;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RetailEquity
{
    public class TradeFilter
    {
        public IEnumerable<Trade> FilterForBank(IEnumerable<Trade> trades, Bank bank, Country country)                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         
        {
            IBank bankFactory;

            if (country == Country.USA)
            {
                bankFactory = new USABankFactory();
            }
            else
            {
                bankFactory = new UKBankFactory();
            }

            return bankFactory.CreateBank(bank).Match(trades);
        }
    }
}