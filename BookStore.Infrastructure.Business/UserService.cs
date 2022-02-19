#nullable enable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStore.Domain.Core.Entities;
using BookStore.Domain.Interfaces;
using BookStore.Services.Interfaces;

namespace BookStore.Infrastructure.Business
{
    public class UserService : IUserService

    {
        private readonly IUserRepository _repository;

        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }


        public User GetById(int id)
        {
            return _repository.GetById(id);
        }

        public void Update(User user)
        {
            _repository.Update(user);
        }

        public ICollection<User> GetAll()
        {
            return _repository.GetAll();
        }

        public string? AuthenticationType { get; }
        public bool IsAuthenticated { get; }
        public string? Name { get; }
    }
}
