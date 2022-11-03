using HouseRentingSystem.Core.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HouseRentingSystem.Core.Cofigurations
{
    public class AgentConfiguration : IEntityTypeConfiguration<Agent>
    {
        private Agent Agent;
        public void Configure(EntityTypeBuilder<Agent> builder)
        {
            builder.HasData(this.Agent = new Agent()
            {
                Id = 1,
                PhoneNumber = "+359888888888",
                UserId = "dea12856-c198-4129-b3f3-b893d8395082"
            }
            );
        }
    }
}
