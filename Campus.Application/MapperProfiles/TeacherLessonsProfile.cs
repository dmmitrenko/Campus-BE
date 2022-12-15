using AutoMapper;
using Campus.DataContext.Entities;
using Campus.Domain.Models;

namespace Campus.Application.MapperProfiles;
public class TeacherLessonsProfile : Profile
{
    public TeacherLessonsProfile()
    {
        CreateMap<TeacherLessons, TeacherLessonsModel>().ReverseMap();
    }
}
