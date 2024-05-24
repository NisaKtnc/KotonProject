using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koton.Entities.Models
{
    public class Categories : BaseEntity
    {
        public int CategoriesId { get; set; } 
        public string CategoryName { get; set; }
        
        public ICollection<Products> Product { get; set; }
    }
}
