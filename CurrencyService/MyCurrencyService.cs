using CurrencyModel;
using System;
using CurrencyBL;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyService
{
    public class MyCurrencyService : ICurrencyService
    {
        public double Convert(Currency source, Currency dest, double amount)
        {
            CurrencyManager manager = new CurrencyManager();
            return manager.Convert(source, dest, amount);
        }

        public CurrencyList GetAllCurrencies()
        {
            CurrencyManager manager = new CurrencyManager();
            return manager.GetCurrencyList();
        }
    }
}
