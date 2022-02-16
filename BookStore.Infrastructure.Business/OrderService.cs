using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStore.Domain.Core.Entities;
using BookStore.Domain.Interfaces;
using BookStore.Services.Interfaces;

namespace BookStore.Infrastructure.Business
{
    public class OrderService : IOrderService

    {
        private readonly IOrderRepository repository;

        public OrderService(IOrderRepository repository)
        {
            this.repository = repository;
        }

        public Order Create(Order order)
        {
            return repository.Create(order);
        }

        public Order GetById(int id)
        {
            return repository.GetById(id);
        }

        public void Delete(int id)
        {
           repository.Delete(id);
        }

        public void Update(Order order)
        {
            repository.Update(order);
        }

        public ICollection<Order> GetAll()
        {
            return repository.GetAll();
        }
    }
}