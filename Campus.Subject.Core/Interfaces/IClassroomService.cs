using Campus.Subject.Domain.Models;

namespace Campus.Subject.Core.Interfaces;
public interface IClassroomService
{
    Task<ClassroomModel> AddClassroomAsync(ClassroomModel classroom);
}
