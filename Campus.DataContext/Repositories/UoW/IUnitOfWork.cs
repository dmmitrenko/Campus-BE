using Campus.DataContext.Repositories.Interfaces;

namespace Campus.DataContext.Repositories.UoW;
public interface IUnitOfWork
{
    IWriteSubjectRepository SubjectRepository { get; }
    IWriteTeacherRepository TeacherRepository { get; }
    IWriteTeacherSubjectRepository TeacherSubjectRepository { get; }
    IWriteClassRepository ClassRepository { get; }
    Task<int> SaveChangesAsync();
}
