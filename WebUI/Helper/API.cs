using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Helper
{
    public class API
    {
        public static class Order
        {
            public static string GetOrderById(string baseUri, string path, int id) => $"{baseUri}{path}/orders/getById?orderID={id}";
            public static string CreateOrder(string baseUri, string path) => $"{baseUri}{path}/orders/Add";
            public static string GetAllOrders(string baseUri, string path) => $"{baseUri}{path}/orders/getAll";

        }                                                                           
    }
}
