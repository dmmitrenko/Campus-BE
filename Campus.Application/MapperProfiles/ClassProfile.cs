using AutoMapper;
using Campus.DataContext.Entities;
using Campus.Domain.Models;

namespace Campus.Application.MapperProfiles;
public class ClassProfile : Profile
{
    public ClassProfile()
    {
        CreateMap<Classroom, ClassroomModel>().ReverseMap();
    }
}
