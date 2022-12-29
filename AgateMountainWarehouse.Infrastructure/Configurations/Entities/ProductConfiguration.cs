using AgateMountainWarehouse.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgateMountainWarehouse.Infrastructure.Configurations.Entities;

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    private const string BaseUrl = $"StaticFiles";

    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.HasData(
            new Product
            {
                Id = new Guid("ffbc3199-8546-4699-a532-c10a32c564cc"),
                Name = "Labradorite",
                Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                Price = 35,
                ImageUrl = $"{BaseUrl}/Images/labradorite.png",
                CreatedDateTime = DateTime.Now,
                UpdatedDateTime = DateTime.Now
            },
            new Product
            {
                Id = new Guid("b8552865-4078-4e4b-8d20-ff0d14d87d8d"),
                Name = "Turquoise",
                Description = "Nunc viverra imperdiet enim. Fusce est. Vivamus a tellus.",
                Price = 20,
                ImageUrl = $"{BaseUrl}/Images/turquoise.png",
                CreatedDateTime = DateTime.Now,
                UpdatedDateTime = DateTime.Now
            },
            new Product
            {
                Id = new Guid("6f6977f5-a099-4add-94f3-1fdcb5e06b92"),
                Name = "Star Garnet",
                Description = "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                Price = 25,
                ImageUrl = $"{BaseUrl}/Images/star-garnet.jpg",
                CreatedDateTime = DateTime.Now,
                UpdatedDateTime = DateTime.Now
            },
            new Product
            {
                Id = new Guid("4ef32bc9-536f-4231-8934-f3ce9d48d111"),
                Name = "Jasper",
                Description = "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                Price = 20,
                ImageUrl = $"{BaseUrl}/Images/jasper.jpg",
                CreatedDateTime = DateTime.Now,
                UpdatedDateTime = DateTime.Now
            },
            new Product
            {
                Id = new Guid("9af4201d-22d7-4579-bc40-341f345cb747"),
                Name = "Fire Opal",
                Description = "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                Price = 18,
                ImageUrl = $"{BaseUrl}/Images/fire-opal.jpg",
                CreatedDateTime = DateTime.Now,
                UpdatedDateTime = DateTime.Now
            },
            new Product
            {
                Id = new Guid("1c5ab034-4ba0-4fb5-9f07-13b06d8f155b"),
                Name = "Amethyst",
                Description = "Nunc viverra imperdiet enim. Fusce est. Vivamus a tellus.",
                Price = 22,
                ImageUrl = $"{BaseUrl}/Images/amethyst.jpg",
                CreatedDateTime = DateTime.Now,
                UpdatedDateTime = DateTime.Now
            },
            new Product
            {
                Id = new Guid("7aad8902-45d5-4185-a2e6-cf466abbbb84"),
                Name = "26 Gauge Gold Wire",
                Description = "Nunc viverra imperdiet enim. Fusce est. Vivamus a tellus.",
                Price = 9,
                ImageUrl = $"{BaseUrl}/Images/gold-wire.jpg",
                CreatedDateTime = DateTime.Now,
                UpdatedDateTime = DateTime.Now
            },
            new Product
            {
                Id = new Guid("ae5e0036-8551-4dab-9e41-674d27b4a8b2"),
                Name = "24 Gauge Gold Wire",
                Description = "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                Price = 8,
                ImageUrl = $"{BaseUrl}/Images/gold-wire.jpg",
                CreatedDateTime = DateTime.Now,
                UpdatedDateTime = DateTime.Now
            },
            new Product
            {
                Id = new Guid("57aea388-8f33-4975-aea7-a587855d87ee"),
                Name = "Agate",
                Description = "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                Price = 38,
                ImageUrl = $"{BaseUrl}/Images/agate.jpg",
                CreatedDateTime = DateTime.Now,
                UpdatedDateTime = DateTime.Now
            },
            new Product
            {
                Id = new Guid("6fc19f3c-5426-4dd4-a1e2-aaebc14ce18a"),
                Name = "Carnelian",
                Description = "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                Price = 18,
                ImageUrl = $"{BaseUrl}/Images/carnelian.jpg",
                CreatedDateTime = DateTime.Now,
                UpdatedDateTime = DateTime.Now
            },
            new Product
            {
                Id = new Guid("6b001338-1a4f-496c-8d26-dee9e111c24d"),
                Name = "Malachite",
                Description = "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                Price = 23,
                ImageUrl = $"{BaseUrl}/Images/malachite.jpg",
                CreatedDateTime = DateTime.Now,
                UpdatedDateTime = DateTime.Now
            },
            new Product
            {
                Id = new Guid("ba12294f-779c-425e-a2d0-9a6a69e8c009"),
                Name = "26 Gauge Silver Wire",
                Description = "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                Price = 8,
                ImageUrl = $"{BaseUrl}/Images/silver-wire.jpg",
                CreatedDateTime = DateTime.Now,
                UpdatedDateTime = DateTime.Now
            },
            new Product
            {
                Id = new Guid("4d1e2f73-94db-4559-b47b-5d7619e39dba"),
                Name = "24 Gauge Silver Wire",
                Description = "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                Price = 7,
                ImageUrl = $"{BaseUrl}/Images/silver-wire.jpg",
                CreatedDateTime = DateTime.Now,
                UpdatedDateTime = DateTime.Now
            },
            new Product
            {
                Id = new Guid("4f8e0392-db1c-4768-8a4f-c54b018f2f81"),
                Name = "26 Gauge Copper Wire",
                Description = "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                Price = 7,
                ImageUrl = $"{BaseUrl}/Images/copper-wire.jpg",
                CreatedDateTime = DateTime.Now,
                UpdatedDateTime = DateTime.Now
            },
            new Product
            {
                Id = new Guid("bc7e516c-5e5b-4949-8384-414cac54e563"),
                Name = "24 Gauge Copper Wire",
                Description = "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                Price = 6,
                ImageUrl = $"{BaseUrl}/Images/copper-wire.jpg",
                CreatedDateTime = DateTime.Now,
                UpdatedDateTime = DateTime.Now
            },
            new Product
            {
                Id = new Guid("9465fec5-3ee4-4d25-ba84-69f3ec21336a"),
                Name = "Sapphire",
                Description = "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                Price = 25,
                ImageUrl = $"{BaseUrl}/Images/sapphire.jpg",
                CreatedDateTime = DateTime.Now,
                UpdatedDateTime = DateTime.Now
            });
            
    }
}
