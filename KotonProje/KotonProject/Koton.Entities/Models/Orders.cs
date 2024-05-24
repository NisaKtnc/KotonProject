using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koton.Entities.Models
{
    public class Orders : BaseEntity
    {
        public int OrdersId { get; set; }   
        public int CustomersId { get; set; }
        public string OrderStatus { get; set; } 
        public string OrderAddress { get; set; }
        public double OrderTotalPrice { get; set; } 
        public string  OrderCargoCompany {  get; set; }
        public string OrderNote { get; set; }
        public int PaymentId { get; set; }
        public string OrderInvoiceAddress {  get; set; }
        public int OrderCurrency {  get; set; }

        // Navigation properties
        public Customers Customer { get; set; }
        public Payment Payments { get; set; }
        public ICollection<Order_details> OrderDetails { get; set; }
        public ICollection<OrderType> OrderTypes { get; set; }


    }
}
