using AutoMapper;
using Campus.Subject.DataContext.Entities;
using Campus.Subject.Domain.Models;

namespace Campus.Subject.Application.MapperProfiles;
public class ClassProfile : Profile
{
    public ClassProfile()
    {
        CreateMap<Classroom, ClassroomModel>().ReverseMap();
    }
}
