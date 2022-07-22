using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Order.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using WebUI.Models;
using WebUI.Services;

namespace WebUI.Controllers
{
    public class RestaurantController : Controller
    {
        private IOrderService _orderService;


        public RestaurantController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public IActionResult Index()
        {
            var listofData = _orderService.FindAllAsync();
            return View(listofData.Result);
        }


        [HttpGet]
        [Route("Restaurant/GetOrders/{OrderId:int}")]
        public async Task<IActionResult> GetOrders([FromRoute] int OrderId)
        {
            var order = await _orderService.FindOneAsync(OrderId);
            return View(order);
        }


        public ActionResult CreateOrder()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrder(Orders order)
        {
            var result = await _orderService.InsertAsync(order);
            return RedirectToAction("Index");
        }
    }
}
