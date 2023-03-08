using AutoMapper;
using Campus.DataContext.Entities;
using Campus.Domain.Models;

namespace Campus.Application.MapperProfiles;
public class EducatorProfile : Profile
{
    public EducatorProfile()
    {
        CreateMap<TeacherModel, Teacher>().ReverseMap();
    }
}
