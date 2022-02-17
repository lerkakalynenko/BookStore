using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStore.Domain.Core.Entities;

namespace BookStore.Services.Interfaces
{
    public interface IBookService
    {
         Book Create(Book book);
         Book GetById(int id);
         void Update(Book book);
         void Delete(int id);
         IEnumerable<Book> GetAll();
         IEnumerable<Book> RangeByCategory(Category category);
         IEnumerable<Book> RangeByPrice();
    }
}
