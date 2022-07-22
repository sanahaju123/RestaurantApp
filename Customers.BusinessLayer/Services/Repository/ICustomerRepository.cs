using Customers.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Customers.WebAPI.Services.Repository
{
    public interface ICustomerRepository
    {
        Task<IEnumerable<Customer>> FindAllAsync();
        Task<Customer> FindOneAsync(int id);
        Task<Customer> InsertAsync(Customer customer);
        Task<Customer> UpdateAsync(Customer customer);
    }
}
