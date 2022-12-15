using AutoMapper;
using Campus.API.Models.Requests;
using Campus.Domain.Models;

namespace Campus.API.MapperProfiles;

public class TeacherLessonsProfile : Profile
{
    public TeacherLessonsProfile()
    {
        CreateMap<AddSubjectForTeacherRequest, TeacherLessonsModel>();
    }
}
