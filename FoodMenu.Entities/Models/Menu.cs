using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodMenu.WebAPI.Models
{
    public class Menu
    {
        public int FoodId { get; set; }
        public string FoodName { get; set; }
        public string FoodType { get; set; }
        public int Rating { get; set; }
        public int Rate { get; set; }
    }
}
