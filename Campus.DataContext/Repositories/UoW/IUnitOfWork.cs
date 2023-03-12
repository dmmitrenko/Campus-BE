using Campus.DataContext.Repositories.Interfaces;

namespace Campus.DataContext.Repositories.UoW;
public interface IUnitOfWork
{
    IWriteCourseRepository SubjectRepository { get; }
    IWriteEducatorRepository TeacherRepository { get; }
    IWriteEducatorCourseRepository TeacherSubjectRepository { get; }
    IWriteClassRepository ClassRepository { get; }
    Task<int> SaveChangesAsync();
}
