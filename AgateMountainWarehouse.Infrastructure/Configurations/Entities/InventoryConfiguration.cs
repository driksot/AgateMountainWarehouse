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
            },
            new Inventory
            {
                Id = Guid.NewGuid(),
                ProductId = new Guid("57aea388-8f33-4975-aea7-a587855d87ee"),
                QuantityOnHand = 6
            },
            new Inventory
            {
                Id = Guid.NewGuid(),
                ProductId = new Guid("6fc19f3c-5426-4dd4-a1e2-aaebc14ce18a"),
                QuantityOnHand = 10
            },
            new Inventory
            {
                Id = Guid.NewGuid(),
                ProductId = new Guid("6b001338-1a4f-496c-8d26-dee9e111c24d"),
                QuantityOnHand = 5
            },
            new Inventory
            {
                Id = Guid.NewGuid(),
                ProductId = new Guid("ba12294f-779c-425e-a2d0-9a6a69e8c009"),
                QuantityOnHand = 9
            },
            new Inventory
            {
                Id = Guid.NewGuid(),
                ProductId = new Guid("4d1e2f73-94db-4559-b47b-5d7619e39dba"),
                QuantityOnHand = 10
            },
            new Inventory
            {
                Id = Guid.NewGuid(),
                ProductId = new Guid("4f8e0392-db1c-4768-8a4f-c54b018f2f81"),
                QuantityOnHand = 3
            },
            new Inventory
            {
                Id = Guid.NewGuid(),
                ProductId = new Guid("bc7e516c-5e5b-4949-8384-414cac54e563"),
                QuantityOnHand = 7
            },
            new Inventory
            {
                Id = Guid.NewGuid(),
                ProductId = new Guid("9465fec5-3ee4-4d25-ba84-69f3ec21336a"),
                QuantityOnHand = 5
            });
    }
}
