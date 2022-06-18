using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webShop.Data.Models;

namespace webShop.Data.interfaces
{
    public interface IAllOrders
    {
        void createOrder(Order order);
    }
}
