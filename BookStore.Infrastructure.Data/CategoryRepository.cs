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
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationContext context;
        private readonly DbSet<Category> dbSet;

        public CategoryRepository(ApplicationContext context)
        {
            this.context = context;
            context.Database.EnsureCreated();
            dbSet = context.Set<Category>();
        }
        public Category Create(Category category)
        {
            var result = context.Add(category);
            context.SaveChanges();
            return result.Entity;
        }

        public Category GetById(int id)
        {
            return dbSet.Find(id);
        }

        public void Update(Category category)
        {
            dbSet.Update(category);
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

        public IEnumerable<Category> GetAll()
        {
            return dbSet.ToList();
        }
    }
}
