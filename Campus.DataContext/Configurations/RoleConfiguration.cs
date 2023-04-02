using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Campus.DataContext.Configurations;
public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
{
    private const string admin = "ADMIN";
    private const string educator = "EDUCATOR";

    public void Configure(EntityTypeBuilder<IdentityRole> builder)
    {
        builder.HasData(
            new IdentityRole
            {
                Name = "Admin",
                NormalizedName = admin
            },
            new IdentityRole
            {
                Name = "Educator",
                NormalizedName = educator
            });
    }
}
