using Campus.Subject.DataContext.Repositories.Implementations;
using Campus.Subject.DataContext.Repositories.Interfaces;
using Microsoft.Extensions.Logging;

namespace Campus.Subject.DataContext.Repositories.UoW;
public class UnitOfWork : IUnitOfWork
{
    private readonly CampusDbContext _context;
    private readonly ILogger _logger;
    private readonly Lazy<IWriteSubjectRepository> _writeSubjectRepository;
    private readonly Lazy<IWriteTeacherRepository> _writeTeacherRepository;
    private readonly Lazy<IWriteTeacherSubjectRepository> _writeTeacherSubjectRepository;
    private readonly Lazy<IWriteClassRepository> _writeClassRepository;

    public UnitOfWork(
        CampusDbContext context,
        ILogger<UnitOfWork> logger)
    {
        _context = context;
        _logger = logger;
        _writeSubjectRepository =
            new Lazy<IWriteSubjectRepository>(() => new WriteSubjectRepository(_logger, _context));
        _writeTeacherRepository =
            new Lazy<IWriteTeacherRepository>(() => new WriteTeacherRepository(_logger, _context));
        _writeTeacherSubjectRepository =
            new Lazy<IWriteTeacherSubjectRepository>(() => new WriteTeacherLessonsRepository(_logger, _context));
        _writeClassRepository =
            new Lazy<IWriteClassRepository>(() => new WriteClassRepository(_logger, _context));
    }

    public IWriteSubjectRepository SubjectRepository => _writeSubjectRepository.Value;

    public IWriteTeacherRepository TeacherRepository => _writeTeacherRepository.Value;

    public IWriteTeacherSubjectRepository TeacherSubjectRepository => _writeTeacherSubjectRepository.Value;

    public IWriteClassRepository ClassRepository => _writeClassRepository.Value;

    public async Task<int> SaveChangesAsync()
    {
        var rows = await _context.SaveChangesAsync();
        _logger.LogInformation($"DB was updated. Rows changed - {rows}");

        return rows;
    }
}
