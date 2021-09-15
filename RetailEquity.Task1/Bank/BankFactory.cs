using System;

namespace RetailEquity.Task1.Bank
{
    public class  BankFactory : IBank
    {
        public IFilter CreateBank(RetailEquity.Bank bank)
        {
            IFilter filter;

            switch (bank)
            {
                case RetailEquity.Bank.Barclays:
                    filter = new BarclaysBank();
                    break;
                case RetailEquity.Bank.Bofa:
                    filter = new BofaBank();
                    break;
                case RetailEquity.Bank.Connacord:
                    filter = new ConnacordBank();
                    break;
                default:
                    throw new Exception("Invalid Bank");
            }

            return filter;
        }

    }
}
