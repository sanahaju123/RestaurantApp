using Customers.WebAPI.Data;
using Customers.WebAPI.Models;
using Customers.WebAPI.Services.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Customers.WebAPI.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task<IEnumerable<Customer>> FindAllAsync()
        {
            return await _customerRepository.FindAllAsync();
        }

        public async Task<Customer> FindOneAsync(int id)
        {
            return await _customerRepository.FindOneAsync(id);
        }

        public async Task<Customer> InsertAsync(Customer customer)
        {
            return await _customerRepository.InsertAsync(customer);
        }

        public async Task<Customer> UpdateAsync(Customer customer)
        {
            return await _customerRepository.UpdateAsync(customer);
        }
    }
}

