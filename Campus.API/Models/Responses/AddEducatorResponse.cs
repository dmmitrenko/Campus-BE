using Campus.Domain.Models;

namespace Campus.API.Models.Responses;

public record AddEducatorResponse(Educator educator)
{
    public Educator Educator { get; init; } = educator;
}
