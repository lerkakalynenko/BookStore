using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Domain.Core.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public User User { get; set; }
        public Book Book { get; set; }
        public int Quantity { get; set; }
    }
}
