using AutoMapper;
using Campus.DataContext.Entities;
using Campus.Domain.Models;

namespace Campus.Application.MapperProfiles;
public class LessonProfile : Profile
{
    public LessonProfile()
    {
        CreateMap<Lesson, LessonModel>().ReverseMap();
    }
}
