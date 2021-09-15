using RetailEquity.Task1.Bank;
using System;
using System.Collections.Generic;
using System.Text;

namespace RetailEquity.Task1.Bank
{
    public class UKBankFactory : IBank
    {
        public IFilter CreateBank(RetailEquity.Bank bank)
        {
            IFilter filter;

            switch (bank)
            {
                case RetailEquity.Bank.Barclays:
                    filter = new UKBarclaysBank();
                    break;
                case RetailEquity.Bank.Bofa:
                    filter = new UKBofaBank();
                    break;
                case RetailEquity.Bank.Connacord:
                    filter = new UKConnacordBank();
                    break;
                case RetailEquity.Bank.DeutscheBank:
                    filter = new UKDeutscheBank();
                    break;
                default:
                    throw new Exception("Invalid Bank");
            }

            return filter;
        }
    }
}
