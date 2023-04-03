using Microsoft.AspNetCore.Identity;

namespace Campus.API.Models.Responses;

public record RegistrationResponse
{
    public IdentityResult Result { get; init; }
}
