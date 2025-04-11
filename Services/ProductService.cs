using ECommerceAPI.DTOs;
using ECommerceAPI.Repositories;
using ECommerceApi2.Models.ECommerceAPI.Models;

namespace ECommerceAPI.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;

        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<ProductDto>> GetAllProductsAsync()
        {
            var products = await _repository.GetAllAsync();
            return products.Select(p => new ProductDto
            {
                Name = p.Name,
                Description = p.Description,
                Price = p.Price
            });
        }

        public async Task<ProductDto> GetProductByIdAsync(int id)
        {
            var product = await _repository.GetByIdAsync(id);
            if (product == null) return null;
            return new ProductDto
            {
                Name = product.Name,
                Description = product.Description,
                Price = product.Price
            };
        }

        public async Task<ProductDto> AddProductAsync(ProductDto productDto)
        {
            var product = new Product
            {
                Name = productDto.Name,
                Description = productDto.Description,
                Price = productDto.Price
            };
            await _repository.AddAsync(product);
            return productDto;
        }

        public async Task UpdateProductAsync(int id, ProductDto productDto)
        {
            var product = await _repository.GetByIdAsync(id);
            if (product == null) return;

            product.Name = productDto.Name;
            product.Description = productDto.Description;
            product.Price = productDto.Price;

            await _repository.UpdateAsync(product);
        }

        public async Task DeleteProductAsync(int id)
        {
            var product = await _repository.GetByIdAsync(id);
            if (product == null) return;

            await _repository.DeleteAsync(product);
        }
    }
}
