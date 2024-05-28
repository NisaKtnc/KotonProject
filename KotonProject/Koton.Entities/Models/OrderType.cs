using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koton.Entities.Models
{
    public class OrderType : BaseEntity
    {
        public int OrderTypeId { get; set; }
        public int OrdersId { get; set; }
        public string OrderTypeName { get; set; }
        public string OrderTypeDescription { get; set; }



        public Orders Orders { get; set; }

        

    }
}
