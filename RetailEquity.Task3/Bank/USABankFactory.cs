using System;

namespace RetailEquity.Task1.Bank
{
    public class  USABankFactory : IBank
    {
        public IFilter CreateBank(RetailEquity.Bank bank)
        {
            IFilter filter;

            switch (bank)
            {
                case RetailEquity.Bank.Barclays:
                    filter = new USABarclaysBank();
                    break;
                case RetailEquity.Bank.Bofa:
                    filter = new USABofaBank();
                    break;
                case RetailEquity.Bank.Connacord:
                    filter = new USAConnacordBank();
                    break;
                case RetailEquity.Bank.DeutscheBank:
                    filter = new USADeutscheBank();
                    break;
                default:
                    throw new Exception("Invalid Bank");
            }

            return filter;
        }

    }
}
