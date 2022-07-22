using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Order.WebAPI.Models;
using Order.WebAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Order.WebAPI.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        // GET: api/orders
        [HttpGet]
        [Route("orders/getAll")]
        public async Task<IActionResult> Get()
        {
            var result = await _orderService.FindAllAsync();
            return Ok(result);
        }

        // POST: api/orders
        [HttpPost]
        [Route("orders/Add")]
        public async Task<IActionResult> Post([FromBody] Orders order)
        {
            var result = await _orderService.InsertAsync(order);
            return Ok(result);
        }

        // PUT: api/orders
        [HttpPut]
        [Route("orders/update")]
        public async Task<IActionResult> Put([FromBody] Orders order)
        {
            var result = await _orderService.UpdateAsync(order);
            return Ok(result);
        }
        // PUT: api/orders
        [HttpGet]
        [Route("orders/getById")]
        public async Task<IActionResult> getById(int orderID)
        {
            var result = await _orderService.FindOneAsync(orderID);
            return Ok(result);
        }
    }
}


