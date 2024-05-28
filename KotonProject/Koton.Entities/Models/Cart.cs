﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koton.Entities.Models
{
    public class Cart : BaseEntity
    {
        public int ProductId { get; set; }        
        public int CustomerId { get; set; }
        public int Quantity { get; set; }
        public double CartTotalPrice { get; set; } 


        public Customer Customer { get; set; }
        public Product Product { get; set; }


    }
}
