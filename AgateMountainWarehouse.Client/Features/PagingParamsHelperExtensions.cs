using AgateMountainWarehouse.Application.RequestFeatures;
using System.Reflection;

namespace AgateMountainWarehouse.Client.Features;

public static class PagingParamsHelperExtensions
{
    public static void SetPrivatePageSize(this PagingParameters pagingParameters, string propName, int pageSize)
    {
        PropertyInfo propertyInfo = typeof(PagingParameters).GetProperty(propName);
        if (propertyInfo is null) return;
        propertyInfo.SetValue(pagingParameters, pageSize);
    }
}
