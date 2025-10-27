using ProductsMvcClient.Models;

namespace ProductsMvcClient.Services
{
    public interface IProductService
    {
        Task<List<Products>> GetAllProductsAsync();
        Task<Products> GetProductByIdAsync(int id);
        Task<bool> CreateProductAsync(Products product);
        Task<bool> UpdateProductAsync(Products product);
        Task<bool> DeleteProductAsync(int id);
        Task<List<CategoryViewModel>> GetCategoriesAsync();
    }
}