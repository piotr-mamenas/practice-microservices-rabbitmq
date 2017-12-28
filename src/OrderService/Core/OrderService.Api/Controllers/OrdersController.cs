using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using eCorp.WebStore.OrderService.Domain;
using eCorp.WebStore.OrderService.Domain.Enums;
using eCorp.WebStore.OrderService.Domain.Interfaces;
using eCorp.WebStore.OrderService.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace eCorp.WebStore.OrderService.Api.Controllers
{
    [Route("api/orders")]
    public class OrdersController : Controller
    {
        private readonly IRepository<Order> _orders;

        public OrdersController(IOrderRepository repository)
        {
            _orders = repository;
        }
        
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var order = new PurchaseOrder()
            {
                Id = Guid.NewGuid(),
                CreatedOn = DateTime.Now,
                CurrencyCode = "CHF",
                IsPaid = false,
                Number = "CHCX104499434",
                PaymentAmount = 30.12m,
                PaymentDaysTerms = 7,
                PlacedTimestamp = DateTime.Now,
                Status = OrderStatus.Initial,
                UpdatedOn = DateTime.Now
            };

            await _orders.AddAsync(order);
            
            var orderInDb = await _orders.GetAsync(order.Id);

            return Json(orderInDb);
        }
        
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
