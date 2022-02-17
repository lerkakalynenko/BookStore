using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStore.Domain.Core.Entities;

namespace BookStore.Services.Contracts
{
    public class OrderDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public Book BookId { get; set; }
        public int Quantity { get; set; }

        public double Sum => Quantity * BookId.Price; 
    }
}
