using AgateMountainWarehouse.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgateMountainWarehouse.Infrastructure.Configurations.Entities;

public class InventoryConfiguration : IEntityTypeConfiguration<Inventory>
{
    public void Configure(EntityTypeBuilder<Inventory> builder)
    {
        builder.HasData(
            new Inventory
            {
                Id = Guid.NewGuid(),
                ProductId = new Guid("ffbc3199-8546-4699-a532-c10a32c564cc"),
                QuantityOnHand = 4
            },
            new Inventory
            {
                Id = Guid.NewGuid(),
                ProductId = new Guid("b8552865-4078-4e4b-8d20-ff0d14d87d8d"),
                QuantityOnHand = 7
            },
            new Inventory
            {
                Id = Guid.NewGuid(),
                ProductId = new Guid("6f6977f5-a099-4add-94f3-1fdcb5e06b92"),
                QuantityOnHand = 3
            },
            new Inventory
            {
                Id = Guid.NewGuid(),
                ProductId = new Guid("4ef32bc9-536f-4231-8934-f3ce9d48d111"),
                QuantityOnHand = 4
            },
            new Inventory
            {
                Id = Guid.NewGuid(),
                ProductId = new Guid("9af4201d-22d7-4579-bc40-341f345cb747"),
                QuantityOnHand = 12
            },
            new Inventory
            {
                Id = Guid.NewGuid(),
                ProductId = new Guid("1c5ab034-4ba0-4fb5-9f07-13b06d8f155b"),
                QuantityOnHand = 8
            },
            new Inventory
            {
                Id = Guid.NewGuid(),
                ProductId = new Guid("7aad8902-45d5-4185-a2e6-cf466abbbb84"),
                QuantityOnHand = 11
            },
            new Inventory
            {
                Id = Guid.NewGuid(),
                ProductId = new Guid("ae5e0036-8551-4dab-9e41-674d27b4a8b2"),
                QuantityOnHand = 9
            });
    }
}
