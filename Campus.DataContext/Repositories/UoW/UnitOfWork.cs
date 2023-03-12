using Campus.DataContext.Repositories.Implementations;
using Campus.DataContext.Repositories.Interfaces;
using Microsoft.Extensions.Logging;

namespace Campus.DataContext.Repositories.UoW;
public class UnitOfWork : IUnitOfWork
{
    private readonly CampusDbContext _context;
    private readonly ILogger _logger;
    private readonly Lazy<IWriteCourseRepository> _writeSubjectRepository;
    private readonly Lazy<IWriteEducatorRepository> _writeTeacherRepository;
    private readonly Lazy<IWriteEducatorCourseRepository> _writeTeacherSubjectRepository;
    private readonly Lazy<IWriteClassRepository> _writeClassRepository;

    public UnitOfWork(
        CampusDbContext context,
        ILogger<UnitOfWork> logger)
    {
        _context = context;
        _logger = logger;
        _writeSubjectRepository =
            new Lazy<IWriteCourseRepository>(() => new WriteCourseRepository(_logger, _context));
        _writeTeacherRepository =
            new Lazy<IWriteEducatorRepository>(() => new WriteEducatorRepository(_logger, _context));
        _writeTeacherSubjectRepository =
            new Lazy<IWriteEducatorCourseRepository>(() => new WriteEducatorCourseRepository(_logger, _context));
        _writeClassRepository =
            new Lazy<IWriteClassRepository>(() => new WriteClassRepository(_logger, _context));
    }

    public IWriteCourseRepository SubjectRepository => _writeSubjectRepository.Value;

    public IWriteEducatorRepository TeacherRepository => _writeTeacherRepository.Value;

    public IWriteEducatorCourseRepository TeacherSubjectRepository => _writeTeacherSubjectRepository.Value;

    public IWriteClassRepository ClassRepository => _writeClassRepository.Value;

    public async Task<int> SaveChangesAsync()
    {
        var rows = await _context.SaveChangesAsync();
        _logger.LogInformation($"DB was updated. Rows changed - {rows}");

        return rows;
    }
}
