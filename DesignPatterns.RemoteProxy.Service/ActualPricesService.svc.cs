using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace DesignPatterns.RemoteProxy.Service
{
    public class ActualPricesService : IActualPrices
    {
        public int GetUsdToUah()
        {
            return new Random().Next(25, 30);
        }

        public int GetEuroToUah()
        {
            return new Random().Next(30, 35);
        }
    }
}
