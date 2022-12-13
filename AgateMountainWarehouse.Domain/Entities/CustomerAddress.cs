using AgateMountainWarehouse.Domain.Common;
using System.ComponentModel.DataAnnotations;

namespace AgateMountainWarehouse.Domain.Entities;

public class CustomerAddress : AuditableEntity
{
    [MaxLength(100)]
    public string AddressLine1 { get; set; } = string.Empty;

    [MaxLength(100)]
    public string AddressLine2 { get; set; } = string.Empty;

    [MaxLength(100)]
    public string City { get; set; } = string.Empty;

    [MaxLength(2)]
    public string State { get; set; } = string.Empty;

    [MaxLength(32)]
    public string Country { get; set; } = string.Empty;

    [MaxLength(10)]
    public string PostalCode { get; set; } = string.Empty;
}
