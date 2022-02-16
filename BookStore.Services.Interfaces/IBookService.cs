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
        public Book Create(Book book);
        public Book GetById(int id);
        public void Update(Book book);
        public void Delete(int id);
        public IEnumerable<Book> GetAll();
    }
}
