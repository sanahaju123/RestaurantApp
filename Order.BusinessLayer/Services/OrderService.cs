using Microsoft.EntityFrameworkCore;
using Order.WebAPI.Data;
using Order.WebAPI.Models;
using Order.WebAPI.Services.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Order.WebAPI.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public async Task<IEnumerable<Orders>> FindAllAsync()
        {
            return await _orderRepository.FindAllAsync();
        }

        public async Task<Orders> FindOneAsync(int id)
        {
            return await _orderRepository.FindOneAsync(id);
        }

        public async Task<Orders> InsertAsync(Orders orders)
        {
            return await _orderRepository.InsertAsync(orders);
        }

        public async Task<Orders> UpdateAsync(Orders orders)
        {
            return await _orderRepository.UpdateAsync(orders);
        }
    }
}


