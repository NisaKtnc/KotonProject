using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koton.Entities.Models
{
    public class Products : BaseEntity
    {
        public int ProductsId { get; set; }
        public int? ReviewsId { get; set; }
        public string ProductName { get; set; }
        public int? SizeId { get; set; } 
        public int CategoriesId { get; set; } 
        public int ProductStock {  get; set; }
        public double ProductPrice { get; set; }
        public string ProductImage { get; set; }   
        public string ProductDescription { get; set; }
        public double SalesPrice { get; set; }

        
        public ICollection<Cart> Carts{ get; set; }
        public Categories Category {  get; set; }
        public Size Sizes { get; set; }
        public ICollection<Reviews> Review { get; set; }
        public ICollection<Order_details> OrderDetails { get; set; }


    }
}
