using AgateMountainWarehouse.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgateMountainWarehouse.Infrastructure.Configurations.Entities;

public class InventorySnapshotConfiguration : IEntityTypeConfiguration<InventorySnapshot>
{
    public void Configure(EntityTypeBuilder<InventorySnapshot> builder)
    {
        builder.HasOne(snapshot => snapshot.Product)
            .WithMany()
            .OnDelete(DeleteBehavior.Restrict);
    }
}
