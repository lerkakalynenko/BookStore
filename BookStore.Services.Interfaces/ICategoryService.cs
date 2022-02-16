using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStore.Domain.Core.Entities;

namespace BookStore.Services.Interfaces
{
    public interface ICategoryService
    {
        public Category Create(Category category);
        public Category GetById(int id);
        public void Update(Category category);
        public void Delete(int id);
        public IEnumerable<Category> GetAll();

    }
}
