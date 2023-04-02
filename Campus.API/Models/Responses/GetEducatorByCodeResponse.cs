using Campus.Domain.Models;

namespace Campus.API.Models.Responses;

public record GetEducatorByCodeResponse
{
    public Educator Educator { get; init; }
}
