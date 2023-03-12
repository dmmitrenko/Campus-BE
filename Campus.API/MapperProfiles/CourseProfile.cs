using AutoMapper;
using Campus.API.Models.Requests;
using Campus.Domain.Models;

namespace Campus.API.MapperProfiles;

public class CourseProfile : Profile
{
    public CourseProfile()
    {
        CreateMap<AddSubjectRequest, Course>();
    }
}
