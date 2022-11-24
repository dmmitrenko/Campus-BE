using AutoMapper;
using Campus.Subject.DataContext.Entities;
using Campus.Subject.Domain.Models;

namespace Campus.Subject.Application.MapperProfiles;
public class LessonProfile : Profile
{
    public LessonProfile()
    {
        CreateMap<Lesson, LessonModel>().ReverseMap();
    }
}
