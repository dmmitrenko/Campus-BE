using AutoMapper;

namespace Campus.Application.MapperProfiles;
public class EducatorCourseProfile : Profile
{
    public EducatorCourseProfile()
    {
        CreateMap<Domain.Models.EducatorCourse, DataContext.Entities.EducatorCourse>().ReverseMap();
    }
}
