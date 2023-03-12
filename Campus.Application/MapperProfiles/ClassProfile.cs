using AutoMapper;

namespace Campus.Application.MapperProfiles;
public class ClassProfile : Profile
{
    public ClassProfile()
    {
        CreateMap<Domain.Models.Classroom, DataContext.Entities.Classroom>().ReverseMap();
    }
}
