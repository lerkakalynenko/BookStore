using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStore.Domain.Core.Entities;

namespace BookStore.Domain.Interfaces
{
    public interface IUserRepository
    {
        
        User GetById(int id);
        void Update(User user);
        ICollection<User> GetAll();
    }
}
