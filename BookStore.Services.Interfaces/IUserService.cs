using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using BookStore.Domain.Core.Entities;

namespace BookStore.Services.Interfaces
{
    public interface IUserService : IIdentity
    {
        User GetById(int id);
        void Update(User user);
        ICollection<User> GetAll();
    }
}
