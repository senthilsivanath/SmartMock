using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Web;
using MockOrderService.DataMembers;

namespace MockOrderService
{
    [ServiceContract]
    public interface IAppStoreOrder
    {
        [OperationContract]
        List<Order> GetCustomerOrderInfo(List<string> orderId);  
    }
}
