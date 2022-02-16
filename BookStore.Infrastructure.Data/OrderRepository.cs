using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStore.Domain.Core.Entities;
using BookStore.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Infrastructure.Data
{
    public class OrderRepository : IOrderRepository
    {
        private readonly ApplicationContext context;
        private readonly DbSet<Order> dbSet;

        public OrderRepository(ApplicationContext context)
        {
            this.context = context;
            context.Database.EnsureCreated();
            dbSet = context.Set<Order>();
        }
        public Order Create(Order order)
        {
            var result = context.Add(order);
            context.SaveChanges();
            return result.Entity;
        }

        public Order GetById(int id)
        {
            return dbSet.Find(id);
        }

        public void Update(Order order)
        {
            dbSet.Update(order);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = GetById(id);
            if (entity != null)
            {

                dbSet.Remove(entity);
                context.SaveChanges();
            }
        }

        public ICollection<Order> GetAll()
        {
            return dbSet.ToList();
        }
    }
}
