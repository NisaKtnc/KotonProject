﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koton.Entities.Models
{
    public class Customers : BaseEntity
    {
        public int CustomersId {  get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; } 
        public string CustomerEmail { get; set; }   

        public string CustomerUsername { get; set; }    
        public string CustomerPassword { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerGender { get; set; }  
        public DateTime CustomerBirthday { get; set; }
        public string CustomerCountry {  get; set; }
        public string CustomerCity { get; set; }
        public string CustomerAdress { get; set; }

        // Navigation properties
        public ICollection<Orders> Order { get; set; }
        public ICollection<Cart> Carts { get; set; }

        public ICollection<Reviews> Review { get; set; }


    }
}