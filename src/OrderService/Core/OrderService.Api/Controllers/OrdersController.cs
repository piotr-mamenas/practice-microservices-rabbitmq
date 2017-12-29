using System;
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
        private readonly IRepository<ShipmentOrder> _shipmentOrders;
        private readonly IRepository<PurchaseOrder> _purchaseOrders;

        public OrdersController(IPurchaseOrderRepository purchasesRepository
            ,IShipmentOrderRepository shipmentsRepository)
        {
            _shipmentOrders = shipmentsRepository;
            _purchaseOrders = purchasesRepository;
        }

        [HttpPost, Route("purchase")]
        public async Task<IActionResult> PlacePurchase(PurchaseOrder order)
        {
            var orderInDb = await _purchaseOrders.GetAsync(order.Id);

            if (orderInDb == null)
            {
                await _purchaseOrders.AddAsync(order);
            }
            return Ok();
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

            await _purchaseOrders.AddAsync(order);
            
            var orderInDb = await _purchaseOrders.GetAsync(order.Id);

            return Json(orderInDb);
        }
    }
}
