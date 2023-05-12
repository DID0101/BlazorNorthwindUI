using BlazorNorthwindUI.Models;
using System.Net.Http.Json;

namespace BlazorNorthwindUI.Services
{
    public class ProductService : IProductService
    {
       private HttpClient _httpClient;
        private ProductService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task Add(ProductLisViewModel productListViewModel)
        {
            //alta API adresi girilecek

            await _httpClient.PostAsJsonAsync(requestUri: " a", productListViewModel);
        }

        public Task<ProductLisViewModel> GetProductById(int productId)
        {
            throw new NotImplementedException();
        }

        public Task<ProductLisViewModel[]> GetProducts()
        {
            return _httpClient.GetFromJsonAsync<ProductLisViewModel[]>(requestUri:"");
        }

        public async Task Save(ProductLisViewModel productListViewModel)
        {
            await _httpClient.PostAsJsonAsync(requestUri: " a", productListViewModel);
        }
    }
}
