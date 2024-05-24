using Koton.Business.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace Koton.Business.DTO_s
{
    public class ProductDto : GeneralMapping
    {

        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public string ProductImage { get; set; }
        public string ProductDescription { get; set; }
        public double SalesPrice { get; set; }

    }
}
