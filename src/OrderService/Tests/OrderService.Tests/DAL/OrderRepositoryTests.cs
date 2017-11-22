using System;
using eCorp.WebStore.OrderService.DAL;
using eCorp.WebStore.OrderService.Domain.Enums;
using eCorp.WebStore.OrderService.Domain.Interfaces;
using eCorp.WebStore.OrderService.Domain.Models;
using NUnit.Framework;

namespace eCorp.WebStore.OrderService.Tests.DAL
{
    [TestFixture]
    public class OrderRepositoryTests
    {
        private readonly IOrderRepository _repository;

        public OrderRepositoryTests()
        {
            var context = new OrderServiceContext(new ConnectionSettings
            {
                ConnectionString = "mongodb://localhost",
                Database = "OrderService"
            });

            _repository = new OrderRepository(context);
        }

        [SetUp]
        public void Init()
        {

        }

        [Test]
        public void GetAsync_ReturnsOneOrder_WhenOrderExists()
        {
        }

        [Test]
        public void FindAsync_ReturnsACollectionOfOrders_WhenPredicateIsTrue()
        {
        }

        [Test]
        public void AddAsync_AddsANewOrder_WhenOrderIsValid()
        {
            var newId = new Guid();
            var newOrder = new PurchaseOrder
            {
                Id = newId,
                IsPaid = false,
                PaymentAmount = 84.34m,
                PaymentDaysTerms = 30,
                Number = "ABCD1234",
                Status = OrderStatus.Initial
            };

            _repository.AddAsync(newOrder);

            var order = _repository.GetAsync(newId);

            Assert.AreEqual(newOrder,order);
        }
    }
}
