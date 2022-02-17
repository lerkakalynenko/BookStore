using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStore.Domain.Core.Entities;

namespace BookStore.Domain.Interfaces
{
    public interface IOrderRepository
    {
         Order Create(Order order);
         Order GetById(int id);
         void Delete(int id);
         void Update(Order order);
         ICollection<Order> GetAll();
    }
}
