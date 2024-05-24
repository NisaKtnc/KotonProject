using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koton.Entities.Models
{
    public class Cart : BaseEntity
    {
        public int CartId { get; set; }
        public int ProductsId { get; set; }        
        public int CustomersId { get; set; }
        public int Quantity { get; set; }
        public double CartTotalPrice { get; set; } 


        public Customers Customer { get; set; }
        public Products Product { get; set; }


    }
}
