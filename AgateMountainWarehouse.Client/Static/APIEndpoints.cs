namespace AgateMountainWarehouse.Client.Static;

internal static class APIEndpoints
{
#if DEBUG
    internal const string _serverBaseUrl = "https://localhost:7252/";
#else
    internal const string _serverBaseUrl = "https://derricksouthworthserver.azurewebsites.net/";
#endif

    internal readonly static string _products = "api/products";
    internal readonly static string _inventories = "api/inventories";
    internal readonly static string _orders = "api/orders";
    internal readonly static string _customers = "api/customers";
}

