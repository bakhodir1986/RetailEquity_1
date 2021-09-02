namespace RetailEquity.Task1.Bank
{
    public abstract class  BankFactory
    {
        //public static IBank CreateBank(RetailEquity.Bank bank)
        //{
        //    IBank _bank;

        //    switch (bank)
        //    {
        //        case RetailEquity.Bank.Barclays:
        //            _bank = new BarclaysBank();
        //            break;
        //        case RetailEquity.Bank.Bofa:
        //            _bank = new BofaBank();
        //            break;
        //        case RetailEquity.Bank.Connacord:
        //            _bank = new ConnacordBank();
        //            break;
        //        default:
        //            throw new System.Exception("Invalid Bank");
        //    }

        //    return _bank;
        //}

        public abstract IBank CreateBank();

    }
}
