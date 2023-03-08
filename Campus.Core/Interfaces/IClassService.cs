using Campus.Domain.Models;

namespace Campus.Core.Interfaces;
public interface IClassService
{
    Task<ClassroomModel> AddClassroomAsync(ClassroomModel classroom);
}
