using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStore.Domain.Core.Entities;

namespace BookStore.Services.Contracts
{
    public class CategoryDto
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public virtual ICollection<Book> Books { get; set; }
    }
}
