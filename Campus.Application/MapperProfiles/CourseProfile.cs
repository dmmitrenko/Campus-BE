using AutoMapper;

namespace Campus.Application.MapperProfiles;
public class CourseProfile : Profile
{
    public CourseProfile()
    {
        CreateMap<Domain.Models.Course, DataContext.Entities.Course>().ReverseMap();
    }
}
