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
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationContext _context;
        private readonly DbSet<User> _dbSet;

        public UserRepository(ApplicationContext context, DbSet<User> dbSet)
        { 
            _context = context;
            _dbSet = dbSet;
           
        }
        public User GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public void Update(User user)
        {
            _dbSet.Update(user);
            _context.SaveChanges();
        }

        public ICollection<User> GetAll()
        {
            return _dbSet.ToList();
        }
    }
}
