using AutoMapper;
using Campus.DataContext.Entities;
using Campus.Domain.Models;

namespace Campus.Application.MapperProfiles;
public class EducatorCourseProfile : Profile
{
    public EducatorCourseProfile()
    {
        CreateMap<TeacherLessons, TeacherLessonsModel>().ReverseMap();
    }
}
