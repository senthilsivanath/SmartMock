using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MockOrderService.DataMembers;
using MockOrderService.Repository;

namespace MockOrderService.Contracts
{
    public class AppStoreOrder : IAppStoreOrder
    {
        public List<Order> GetCustomerOrderInfo(List<string> orderId)
        {
            return new XMLProcess().GetOrders(orderId);
        }


    }
}