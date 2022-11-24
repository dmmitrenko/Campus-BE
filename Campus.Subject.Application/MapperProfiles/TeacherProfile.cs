using AutoMapper;
using Campus.Subject.DataContext.Entities;
using Campus.Subject.Domain.Models;

namespace Campus.Subject.Application.MapperProfiles;
public class TeacherProfile : Profile
{
    public TeacherProfile()
    {
        CreateMap<TeacherModel, Teacher>().ReverseMap();
    }
}
