using AutoMapper;

namespace Campus.Application.MapperProfiles;
public class EducatorProfile : Profile
{
    public EducatorProfile()
    {
        CreateMap<Domain.Models.Educator, DataContext.Entities.Educator>().ReverseMap();
    }
}
