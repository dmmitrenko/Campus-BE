using AutoMapper;
using Campus.API.Models.Requests;
using Campus.Domain.Models;

namespace Campus.API.MapperProfiles;

public class LessonProfile : Profile
{
    public LessonProfile()
    {
        CreateMap<AddSubjectRequest, LessonModel>();
    }
}
