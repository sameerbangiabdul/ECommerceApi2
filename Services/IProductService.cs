using ECommerceAPI.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ECommerceAPI.Services
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetAllProductsAsync();
        Task<ProductDto> GetProductByIdAsync(int id);
        Task<ProductDto> AddProductAsync(ProductDto productDto);
        Task UpdateProductAsync(int id, ProductDto productDto);
        Task DeleteProductAsync(int id);
    }
}
