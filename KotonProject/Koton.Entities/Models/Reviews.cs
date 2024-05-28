using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koton.Entities.Models
{
    public class Reviews : BaseEntity
    {
        public int ReviewsId { get; set; }
        public int ProductsId { get; set; }
        public int CustomersId { get; set; }
        public double Ratings { get; set; }
        public string ReviewsTitle { get; set; }
        public string ReviewsDescription { get; set; }
        public string ReviewsStatus { get; set; }
        public string ReviewsImage { get; set; }
        public Customers Customer { get; set; }
        public Products Product { get; set; }

    }
}
