namespace AgateMountainWarehouse.Domain.Entities;

public class SalesOrderItem
{
    public Guid Id { get; set; }
    public Product Product { get; set; } = new Product();
    public int Quantity { get; set; }
}
