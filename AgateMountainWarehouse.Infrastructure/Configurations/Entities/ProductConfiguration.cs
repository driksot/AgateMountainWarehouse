using AgateMountainWarehouse.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgateMountainWarehouse.Infrastructure.Configurations.Entities;

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.HasData(
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "Labradorite",
                Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                Price = 35,
                ImageUrl = "images/products/labradorite.png",
                CreatedDateTime = DateTime.Now,
                UpdatedDateTime = DateTime.Now
            },
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "Turquoise",
                Description = "Nunc viverra imperdiet enim. Fusce est. Vivamus a tellus.",
                Price = 20,
                ImageUrl = "images/products/turquoise.png",
                CreatedDateTime = DateTime.Now,
                UpdatedDateTime = DateTime.Now
            },
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "Star Garnet",
                Description = "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                Price = 25,
                ImageUrl = "images/products/star-garnet.png",
                CreatedDateTime = DateTime.Now,
                UpdatedDateTime = DateTime.Now
            },
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "Jasper",
                Description = "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                Price = 20,
                ImageUrl = "images/products/jasper.png",
                CreatedDateTime = DateTime.Now,
                UpdatedDateTime = DateTime.Now
            },
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "Fire Opal",
                Description = "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                Price = 18,
                ImageUrl = "images/products/fire-opal.png",
                CreatedDateTime = DateTime.Now,
                UpdatedDateTime = DateTime.Now
            },
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "Amethyst",
                Description = "Nunc viverra imperdiet enim. Fusce est. Vivamus a tellus.",
                Price = 22,
                ImageUrl = "images/products/amethyst.png",
                CreatedDateTime = DateTime.Now,
                UpdatedDateTime = DateTime.Now
            },
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "26 Gauge Gold Wire",
                Description = "Nunc viverra imperdiet enim. Fusce est. Vivamus a tellus.",
                Price = 9,
                ImageUrl = "images/products/26-gauge-gold-wire.png",
                CreatedDateTime = DateTime.Now,
                UpdatedDateTime = DateTime.Now
            },
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "24 Gauge Gold Wire",
                Description = "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                Price = 8,
                ImageUrl = "images/products/24-gauge-gold-wire.png",
                CreatedDateTime = DateTime.Now,
                UpdatedDateTime = DateTime.Now
            });
    }
}
