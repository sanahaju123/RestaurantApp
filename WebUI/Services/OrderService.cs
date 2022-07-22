using Newtonsoft.Json;
using Order.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using WebUI.Helper;
using WebUI.Models;

namespace WebUI.Services
{
    public class OrderService : IOrderService
    {
       
        private static HttpClient _client = new HttpClient(new HttpClientHandler { AllowAutoRedirect = false });
        readonly string _baseUrl = "http://localhost:54806/";
        readonly string _path = "api/Order";
        //http://localhost:54806/api/Order/orders/getById?orderID=1
        public OrderService()
        {
            if (_client.BaseAddress == null)
            {
                _client.BaseAddress = new Uri(_baseUrl);
                _client.DefaultRequestHeaders.Accept.Clear();
                _client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));
            }
        }

        public async Task<IEnumerable<OrderModel>> FindAllAsync()
        {
            var result = new List<OrderModel>();
            var uri = API.Order.GetAllOrders(_baseUrl, _path);
            HttpResponseMessage response = _client.GetAsync(uri).Result;
            if (response.IsSuccessStatusCode)
            {
                var jsonDataStatus = response.Content.ReadAsStringAsync().Result;
                var data = JsonConvert.DeserializeObject<IEnumerable<OrderModel>>(jsonDataStatus);
                result = data.ToList();
                return data;
            }
            return result;
        }

        public async Task<OrderModel> FindOneAsync(int id)
        {
            var result = new OrderModel();
            var uri = API.Order.GetOrderById(_baseUrl, _path, id);
            HttpResponseMessage response = _client.GetAsync(uri).Result;
            if (response.IsSuccessStatusCode)
            {
                var jsonDataStatus = response.Content.ReadAsStringAsync().Result;
                var data = JsonConvert.DeserializeObject<OrderModel>(jsonDataStatus);
                return data;
            }
            return result;
        }
        public async Task<Orders> InsertAsync(Orders order)
        {
            var result = new Orders();
            var uri = API.Order.CreateOrder(_baseUrl, _path);         
            var content = JsonConvert.SerializeObject(order);
            HttpResponseMessage response = await _client.PostAsync(uri, new StringContent(content, Encoding.Default,
                           "application/json"));
            if (response.IsSuccessStatusCode)
            {
                var jsonDataStatus = response.Content.ReadAsStringAsync().Result;
                result = JsonConvert.DeserializeObject<Orders>(jsonDataStatus);
                
            }
            return result;
        }
    }
}
