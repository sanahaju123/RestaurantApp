using FoodMenu.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodMenu.WebAPI.Services
{
    public interface IMenuService
    {
        Task<IEnumerable<Menu>> FindAllAsync();
        Task<Menu> FindOneAsync(int id);
        Task<Menu> InsertAsync(Menu menu);
        Task<Menu> UpdateAsync(Menu menu);
    }
}
