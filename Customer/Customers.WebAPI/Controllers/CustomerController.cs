using Customers.WebAPI.Models;
using Customers.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Order.WebAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Customers.WebAPI.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        // GET: api/customers
        [HttpGet]
        [Route("customers/getall")]
        public async Task<IActionResult> GetCustomer()
        {
            var result = await _customerService.FindAllAsync();
            return Ok(result);
        }

        // POST: api/customers
        [HttpPost]
        [Route("customers/add")]
        public async Task<IActionResult> PostCustomer([FromBody] Customer customer)
        {
            var result = await _customerService.InsertAsync(customer);
            return Ok(result);
        }

        // PUT: api/customers 
        [HttpPut]
        [Route("customers/update")]
        public async Task<IActionResult> PutCustomer([FromBody] Customer customer)
        {
            var result = await _customerService.UpdateAsync(customer);
            return Ok(result);
        }

        // PUT: api/customers 
        [HttpGet]
        [Route("customers/getById")]
        public async Task<IActionResult> GetCustomerById(int customerId)
        {
            var result = await _customerService.FindOneAsync(customerId);
            return Ok(result);
        }

    }
}