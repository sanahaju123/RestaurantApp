using Order.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Models;

namespace WebUI.Services
{
    public interface IOrderService
    {
        public Task<OrderModel> FindOneAsync(int id);
        Task<Orders> InsertAsync(Orders orders);
        Task<IEnumerable<OrderModel>> FindAllAsync();
    }
}
