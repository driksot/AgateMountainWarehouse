using System.ComponentModel.DataAnnotations;

namespace AgateMountainWarehouse.Domain.Common;

public abstract class AuditableEntity
{
    [Key]
    public Guid Id { get; set; }
    public DateTime CreatedDateTime { get; set; }
    public DateTime? UpdatedDateTime { get; set; }
}
