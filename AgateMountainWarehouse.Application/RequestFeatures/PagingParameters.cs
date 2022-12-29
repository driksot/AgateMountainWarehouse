namespace AgateMountainWarehouse.Application.RequestFeatures;

public class PagingParameters
{
    const int maxPageSize = 50;
    public int PageNumber { get; set; } = 1;
    private int _pageSize = 10;
    public int PageSize
    {
        get
        {
            return _pageSize;
        }
        set
        {
            _pageSize = (value > maxPageSize) ? maxPageSize : value;
        }
    }

    public string SearchTerm { get; set; } = string.Empty;
    public string OrderBy { get; set; } = "name";
}
