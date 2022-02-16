﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStore.Domain.Core.Entities;

namespace BookStore.Services.Interfaces
{
    public interface IOrderService
    {
        public Order Create(Order order);
        public Order GetById(int id);
        public void Delete(int id);
        public void Update(Order order);
        public ICollection<Order> GetAll();
    }
}