using Koton.DAL.Abstract;
using Koton.Entities.Context;
using Koton.Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koton.DAL.Concrete
{
    public class ProductRepository : Repository<Products>, IProductRepository
    {
        private readonly KotonDbContext _dbContext;
       
        public ProductRepository(KotonDbContext kotonDbContext) : base(kotonDbContext)
        {
            _dbContext = kotonDbContext;           
        }

        public async Task<IEnumerable<Products>> GetAllProductAsync()
        {
            return await _dbContext.Product.ToListAsync();
        }

        public async Task<Products> GetProductByIdAsync(int id)
        {
            return await _dbContext.Product.FindAsync(id);
        }
        //public async Task<Products> AddAsync()
        //{
        //    return await _dbContext.Product.AddAsync();
        //}
    }
}