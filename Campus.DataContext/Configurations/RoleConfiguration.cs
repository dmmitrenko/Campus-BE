using Campus.Domain.Enums;
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
                Name = Roles.Admin.ToString(),
                NormalizedName = admin
            },
            new IdentityRole
            {
                Name = Roles.Educator.ToString(),
                NormalizedName = educator
            });
    }
}
