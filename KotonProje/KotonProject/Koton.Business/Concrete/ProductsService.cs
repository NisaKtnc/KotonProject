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

namespace Koton.Business.Concrete
{
    public class ProductsService : IProductsService
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;
        public ProductsService(IProductRepository productRepository)
        {
            this._productRepository = productRepository;
        }

        //public async Task<Products> AddProduct(ProductDto productDto)
        //{
        //    var product = _mapper.Map<ProductDto>(productDto);
        //    await _productRepository.AddAsync(Products);
        //}

        //public async Task<Products> AddProduct(ProductDto productDto)
        //{

        //    //mapleyip, productdto -> product;
        //    //return await _productRepository.AddAsync(productDto);
        //}

        //Batuhan nisayı çok seviyor <3
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
