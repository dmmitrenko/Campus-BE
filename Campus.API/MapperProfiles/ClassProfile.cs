using AutoMapper;
using Campus.API.Models.Requests;
using Campus.Domain.Models;

namespace Campus.API.MapperProfiles;

public class ClassProfile : Profile
{
    public ClassProfile()
    {
        CreateMap<AddClassroomRequest, Classroom>();
    }
}
