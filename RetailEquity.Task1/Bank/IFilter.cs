using RetailEquity.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace RetailEquity.Task1.Bank
{
    public interface IFilter
    {
        IEnumerable<Trade> Match(IEnumerable<Trade> trades);
    }
}
