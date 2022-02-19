using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStore.Domain.Core;
using BookStore.Domain.Core.Entities;
using BookStore.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Infrastructure.Data
{
    public class BookRepository : IBookRepository
    {
        private readonly ApplicationContext context;
        private readonly DbSet<Book> dbSet;
        private readonly ICategoryRepository categoryRepository;

        public BookRepository(ApplicationContext context, ICategoryRepository categoryRepository)
        {
            this.context = context;
            this.categoryRepository = categoryRepository;
            context.Database.EnsureCreated();
            dbSet = context.Set<Book>();
        }
        public Book Create(Book book)
        {
            var result = context.Add(book);
            context.SaveChanges();
            return result.Entity;
        }

        public Book GetById(int id)
        {
            return dbSet.Find(id);
        }

        public void Update(Book book)
        {
            dbSet.Update(book);
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

        public IEnumerable<Book> GetAll()
        {
            return dbSet.ToList();
        }

        
    }
}
