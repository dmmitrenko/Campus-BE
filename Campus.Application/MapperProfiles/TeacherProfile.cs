using AutoMapper;
using Campus.DataContext.Entities;
using Campus.Domain.Models;

namespace Campus.Application.MapperProfiles;
public class TeacherProfile : Profile
{
    public TeacherProfile()
    {
        CreateMap<TeacherModel, Teacher>().ReverseMap();
    }
}
