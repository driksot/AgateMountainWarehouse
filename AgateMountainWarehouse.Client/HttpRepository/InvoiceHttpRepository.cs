using AgateMountainWarehouse.Client.Static;
using AgateMountainWarehouse.Client.ViewModels;
using System.Text.Json;
using System.Text;

namespace AgateMountainWarehouse.Client.HttpRepository;

public class InvoiceHttpRepository : IInvoiceHttpRepository
{
    private readonly HttpClient _httpClient;
    private readonly JsonSerializerOptions _options;

    public InvoiceHttpRepository(HttpClient httpClient)
    {
        _httpClient = httpClient;
        _options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
    }

    public async Task GenerateInvoice(InvoiceViewModel invoice)
    {
        var content = JsonSerializer.Serialize(invoice);
        var bodyContent = new StringContent(content, Encoding.UTF8, "application/json");

        var postResult = await _httpClient.PostAsync(APIEndpoints._orders, bodyContent);
        var postContent = await postResult.Content.ReadAsStringAsync();

        if (!postResult.IsSuccessStatusCode)
        {
            throw new ApplicationException(postContent);
        }
    }
}
