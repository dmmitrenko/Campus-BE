using AutoMapper;
using Campus.Subject.Domain.Models;
using Campus_Subject.API.Models.Requests;

namespace Campus_Subject.API.MapperProfiles;

public class TeacherProfile : Profile
{
    public TeacherProfile()
    {
        CreateMap<AddTeacherRequest, TeacherModel>();
    }
}
