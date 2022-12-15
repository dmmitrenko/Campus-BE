using Campus.Domain.Models;

namespace Campus.Core.Interfaces;
public interface IClassroomService
{
    Task<ClassroomModel> AddClassroomAsync(ClassroomModel classroom);
}
