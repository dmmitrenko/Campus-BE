using AutoMapper;
using Campus.API.Models.Requests;
using Campus.Domain.Models;

namespace Campus.API.MapperProfiles;

public class EducatorCourseProfile : Profile
{
    public EducatorCourseProfile()
    {
        CreateMap<AddSubjectForTeacherRequest, TeacherLessonsModel>();
    }
}
