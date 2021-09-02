using RetailEquity.Model;
using RetailEquity.Task1.Bank;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RetailEquity
{
    public class TradeFilter
    {
        private BankFactory Initialize(Bank bank)
        {
            BankFactory bankFactory;

            switch (bank)
            {
                case Bank.Barclays:
                    bankFactory = new BarclaysBankFactory();
                    break;
                case Bank.Bofa:
                    bankFactory = new BofaBankFactory();
                    break;
                case Bank.Connacord:
                    bankFactory = new ConnacordBankFactory();
                    break;
                default:
                    throw new Exception("Invalid Bank");
            }

            return bankFactory;
        }

        public IEnumerable<Trade> FilterForBank(IEnumerable<Trade> trades, Bank bank)                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         
        {
            return Initialize(bank).CreateBank().Match(trades);
        }
    }
}