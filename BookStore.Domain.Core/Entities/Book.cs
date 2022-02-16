using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Domain.Core.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string BookName { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public Category IdCategory { get; set; }

    }
}
