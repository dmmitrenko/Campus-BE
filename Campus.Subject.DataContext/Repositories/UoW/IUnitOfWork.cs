using Campus.Subject.DataContext.Repositories.Interfaces;

namespace Campus.Subject.DataContext.Repositories.UoW;
public interface IUnitOfWork
{
    IWriteSubjectRepository SubjectRepository { get; }
    Task<int> SaveChangesAsync();
}
