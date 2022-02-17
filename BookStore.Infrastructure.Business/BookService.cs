using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using BookStore.Domain.Core.Entities;
using BookStore.Domain.Interfaces;
using BookStore.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Infrastructure.Business
{
    public class BookService : IBookService


    {
        private readonly IBookRepository repository;
        private readonly ICategoryRepository categoryRepository;
        private readonly Book book;
        public BookService(IBookRepository repository, ICategoryRepository categoryRepository, Book book)
        {
            this.repository = repository;
            this.categoryRepository = categoryRepository;
            this.book = book;
        }

        public Book Create(Book book)
        {
            return repository.Create(book);
        }

        public Book GetById(int id)
        {
            return repository.GetById(id);
        }

        public void Update(Book book)
        {
            repository.Update(book);
        }

        public void Delete(int id)
        {
            repository.Delete(id);
        }

        public IEnumerable<Book> GetAll()
        {
            return repository.GetAll();
        }

        public IEnumerable<Book> RangeByCategory(Category category)
        {
            throw new NotImplementedException();
        }

       
        //TODO
        public IEnumerable<Book> RangeByPrice()
        {
            return repository.GetAll()
                ;
        }
    }
}
