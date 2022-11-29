namespace AgateMountainWarehouse.Client.Static;

internal static class APIEndpoints
{
#if DEBUG
    internal const string _serverBaseUrl = "https://localhost:7252/api/";
#else
    internal const string _serverBaseUrl = "https://derricksouthworthserver.azurewebsites.net/api/";
#endif

    internal readonly static string _products = "products";
    internal readonly static string _inventories = "inventories";
    internal readonly static string _orders = "orders";
}

