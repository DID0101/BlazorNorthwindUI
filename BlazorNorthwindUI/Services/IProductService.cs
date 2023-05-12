using BlazorNorthwindUI.Models;

namespace BlazorNorthwindUI.Services
{
    public interface IProductService
    {
        Task<ProductLisViewModel[]> GetProducts();
        Task Add(ProductLisViewModel productListViewModel);
        Task Save(ProductLisViewModel productListViewModel);
        Task <ProductLisViewModel> GetProductById(int productId);
    }
}
