using AutoMapper;
using Campus.API.Models.Requests;
using Campus.Domain.Models;

namespace Campus.API.MapperProfiles;

public class EducatorProfile : Profile
{
    public EducatorProfile()
    {
        CreateMap<AddEducatorRequest, Educator>();
    }
}
