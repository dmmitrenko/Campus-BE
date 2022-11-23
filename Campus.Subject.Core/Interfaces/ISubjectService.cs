using Campus.Subject.Domain.Models;

namespace Campus.Subject.Core.Interfaces;
public interface ISubjectService
{
    Task<LessonModel> AddSubjectAsync(LessonModel lesson);
}
