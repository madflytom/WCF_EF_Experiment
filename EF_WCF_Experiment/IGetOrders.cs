using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace EF_WCF_Experiment
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IGetOrders
    {

        [OperationContract]
        Order GetData(int value);
        [OperationContract]
        string SetData(string orderMessage);

    }


   
}
