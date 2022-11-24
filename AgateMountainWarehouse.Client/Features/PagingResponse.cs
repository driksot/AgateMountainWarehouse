using AgateMountainWarehouse.Application.RequestFeatures;

namespace AgateMountainWarehouse.Client.Features;

public class PagingResponse<T> where T : class
{
    public List<T> Items { get; set; } = new List<T>();
    public PagingMetaData MetaData { get; set; } = new PagingMetaData();
}
