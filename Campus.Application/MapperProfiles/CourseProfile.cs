using AutoMapper;
using Campus.DataContext.Entities;
using Campus.Domain.Models;

namespace Campus.Application.MapperProfiles;
public class CourseProfile : Profile
{
    public CourseProfile()
    {
        CreateMap<Lesson, LessonModel>().ReverseMap();
    }
}
