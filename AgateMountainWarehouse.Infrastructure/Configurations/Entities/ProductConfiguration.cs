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
            });
    }
}
