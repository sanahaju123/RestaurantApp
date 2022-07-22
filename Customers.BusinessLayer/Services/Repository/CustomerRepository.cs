using Customers.WebAPI.Data;
using Customers.WebAPI.Models;
using Microsoft.EntityFrameworkCore;
using Order.WebAPI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Customers.WebAPI.Services.Repository
{
    public class CustomerRepository:ICustomerRepository
    {
        private readonly CustomerDbContext _dbContext;

        public CustomerRepository(CustomerDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Customer>> FindAllAsync()
        {
            try
            {
                return (IEnumerable<Customer>)await _dbContext.Customers.ToListAsync();
            }
            catch (Exception)
            {
                return null;
            }

        }

        public async Task<Customer> FindOneAsync(int id)
        {
            try
            {
                return await _dbContext.Customers.FirstOrDefaultAsync(x => x.Id == id);

            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<Customer> InsertAsync(Customer customer)
        {
            try
            {
                _dbContext.Add(customer);
                await _dbContext.SaveChangesAsync();
                return customer;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<Customer> UpdateAsync(Customer customer)
        {
            try
            {
                _dbContext.Update(customer);
                await _dbContext.SaveChangesAsync();
                return customer;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
