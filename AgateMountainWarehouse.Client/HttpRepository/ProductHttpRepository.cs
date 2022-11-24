using AgateMountainWarehouse.Client.ViewModels;
using System.Text.Json;

namespace AgateMountainWarehouse.Client.HttpRepository;

public class ProductHttpRepository : IProductHttpRepository
{
    private readonly HttpClient _httpClient;
    private readonly JsonSerializerOptions _options;

    public ProductHttpRepository(HttpClient httpClient)
    {
        _httpClient = httpClient;
        _options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
    }

    public async Task<List<ProductViewModel>> GetProducts()
    {
        var response = await _httpClient.GetAsync("products");
        var content = await response.Content.ReadAsStringAsync();
        if (!response.IsSuccessStatusCode)
        {
            throw new ApplicationException(content);
        }

        var products = JsonSerializer.Deserialize<List<ProductViewModel>>(content, _options);
        return products;
    }
}
