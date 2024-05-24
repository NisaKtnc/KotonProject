using Koton.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Koton.DAL.Concrete;
using Koton.Business.DTO_s;


namespace Koton.Business.Abstract
{
    public interface IProductsService
    {
        Task<IEnumerable<Products>> GetAllProductsAsync();
        Task<Entities.Models.Products> GetProductById(int Id);
        //Task<Products> AddProduct(ProductDto productDto);

    }
}
