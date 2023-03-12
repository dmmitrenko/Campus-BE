using Campus.Domain.Models;

namespace Campus.Core.Interfaces;
public interface IClassService
{
    Task<Classroom> AddClassroomAsync(Classroom classroom);
}
