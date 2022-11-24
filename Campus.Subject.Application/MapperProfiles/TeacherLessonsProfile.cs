using AutoMapper;
using Campus.Subject.DataContext.Entities;
using Campus.Subject.Domain.Models;

namespace Campus.Subject.Application.MapperProfiles;
public class TeacherLessonsProfile : Profile
{
    public TeacherLessonsProfile()
    {
        CreateMap<TeacherLessons, TeacherLessonsModel>().ReverseMap();
    }
}
