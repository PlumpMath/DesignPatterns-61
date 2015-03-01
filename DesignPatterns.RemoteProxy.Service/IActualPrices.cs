using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace DesignPatterns.RemoteProxy.Service
{
    [ServiceContract]
    public interface IActualPrices
    {
        [OperationContract]
        int GetUsdToUah();

        [OperationContract]
        int GetEuroToUah();
    }
}
