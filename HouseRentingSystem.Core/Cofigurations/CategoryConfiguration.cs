using HouseRentingSystem.Core.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HouseRentingSystem.Core.Cofigurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        private Category CottageCategory;
        private Category SingleCategory;
        private Category DuplexCategory;

        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                this.CottageCategory = new Category()
                {
                    Id = 1,
                    Name = "Cottage"
                },
                this.SingleCategory = new Category()
                {
                    Id = 2,
                    Name = "Single-Family"
                },
                this.DuplexCategory = new Category()
                {
                    Id = 3,
                    Name = "Duplex"
                }
            );
        }
    }
}
