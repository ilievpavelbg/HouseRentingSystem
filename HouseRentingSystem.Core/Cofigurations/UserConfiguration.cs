using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HouseRentingSystem.Core.Cofigurations
{
    public class UserConfiguration : IEntityTypeConfiguration<IdentityUser>
    {
        private IdentityUser AgentUser { get; set; } = null!;
        private IdentityUser GuestUser { get; set; } = null!;

        public void Configure(EntityTypeBuilder<IdentityUser> builder)
        {
            builder.HasData(CreateUsers());
        }

        private IEnumerable<IdentityUser> CreateUsers()
        {
            var users = new List<IdentityUser>();   
            var hasher = new PasswordHasher<IdentityUser>();

            this.AgentUser = new IdentityUser()
            {
                Id = "dea12856-c198-4129-b3f3-b893d8395082",
                UserName = "agent@mail.com",
                NormalizedUserName = "agent@mail.com",
                Email = "agent@mail.com",
                NormalizedEmail = "agent@mail.com"
            };

            this.AgentUser.PasswordHash = hasher.HashPassword(this.AgentUser, "agent123");

            users.Add(this.AgentUser);

            this.GuestUser = new IdentityUser()
            {
                Id = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                UserName = "guest@mail.com",
                NormalizedUserName = "guest@mail.com",
                Email = "guest@mail.com",
                NormalizedEmail = "guest@mail.com"
            };

            this.GuestUser.PasswordHash = hasher.HashPassword(this.AgentUser, "guest123");

            users.Add(this.GuestUser);

            return users;

        }
    }
}
