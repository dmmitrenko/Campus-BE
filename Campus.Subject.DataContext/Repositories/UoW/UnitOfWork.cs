using Campus.Subject.DataContext.Repositories.Implementations;
using Campus.Subject.DataContext.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Campus.Subject.DataContext.Repositories.UoW;
public class UnitOfWork : IUnitOfWork
{
    private readonly CampusDbContext _context;
    private readonly ILogger _logger;
    private readonly Lazy<IWriteSubjectRepository> _writeSubjectRepository;

    public UnitOfWork(
        CampusDbContext context,
        ILogger<UnitOfWork> logger)
    {
        _context = context;
        _logger = logger;
        _writeSubjectRepository =
            new Lazy<IWriteSubjectRepository>(() => new WriteSubjectRepository(_logger, _context));
    }

    public IWriteSubjectRepository SubjectRepository => _writeSubjectRepository.Value;

    public async Task<int> SaveChangesAsync()
    {
        var rows = await _context.SaveChangesAsync();
        _logger.LogInformation($"DB was updated. Rows changed - {rows}");

        return rows;
    }
}
