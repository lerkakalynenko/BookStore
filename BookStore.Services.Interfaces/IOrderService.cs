using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStore.Domain.Core.Entities;

namespace BookStore.Services.Interfaces
{
    public interface IOrderService
    {
         Order Create(Order order);
         Order GetById(int id);
         void Delete(int id);
         void Update(Order order);
         ICollection<Order> GetAll();
    }
}
