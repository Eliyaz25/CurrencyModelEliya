using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using CurrencyBL;
using CurrencyModel;

namespace CurrencyService
{
    [ServiceContract]
    public interface ICurrencyService
    {
        [OperationContract]
        CurrencyList GetAllCurrencies();

        [OperationContract]
        double Convert(Currency source, Currency dest, double amount);

    }
}
