﻿using KARAKATA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class CartItem
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; } = default!;
        public int ProductId { get; set; }
        public Product Product { get; set; } = default!;
        public int Quantity { get; set; }
    }

}
