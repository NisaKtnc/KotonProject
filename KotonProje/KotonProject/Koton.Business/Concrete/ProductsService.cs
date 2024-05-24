using Koton.Business.Abstract;
using Koton.DAL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Koton.Entities.Models;
using Koton.DAL.Concrete;
using Koton.Business.DTO_s;
using AutoMapper;
using Koton.Entities.Context;

namespace Koton.Business.Concrete
{
    public class ProductsService : IProductsService
    {
        private readonly IProductRepository _productRepository;
        private readonly KotonDbContext _context;
        private readonly IMapper _mapper;
        public ProductsService(IMapper mapper,IProductRepository productRepository,KotonDbContext context)
        {
            this._productRepository = productRepository; 
            this._mapper = mapper;
            _context = context;
        }      
        public async Task<Products> AddProduct(ProductDto productDto)
        {
            // Dto'dan Product nesnesine dönüşüm
            var product = new Products
            {
                // Dto'daki alanları Product alanlarına eşledim
                ProductName = productDto.ProductName,
                ProductPrice = productDto.ProductPrice,               
            };
            // Veritabanına ekleme
            var result = await _context.Product.AddAsync(product);
            await _context.SaveChangesAsync();

            // Eklenen ürünü döndürme
            return result.Entity;
        }
        public async Task<IEnumerable<Entities.Models.Products>> GetAllProductsAsync()
        {

            return await _productRepository.GetAllAsync();

        }

        public async Task<Products> GetProductById(int Id)
        {
            return await _productRepository.GetByIdAsync(Id);
        }
    }
}
