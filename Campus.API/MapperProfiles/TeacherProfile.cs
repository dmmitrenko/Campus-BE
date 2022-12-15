using AutoMapper;
using Campus.API.Models.Requests;
using Campus.Domain.Models;

namespace Campus.API.MapperProfiles;

public class TeacherProfile : Profile
{
    public TeacherProfile()
    {
        CreateMap<AddTeacherRequest, TeacherModel>();
    }
}
