using AutoMapper;
using Campus.Core.Interfaces;
using Campus.DataContext.Entities;
using Campus.DataContext.Repositories.UoW;
using Campus.Domain.Models;

namespace Campus.Application.Services;
public class ClassService : IClassService
{
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;

    public ClassService(
        IMapper mapper,
        IUnitOfWork unitOfWork)
    {
        _mapper = mapper;
        _unitOfWork = unitOfWork;
    }

    public async Task<Domain.Models.Classroom> AddClassroomAsync(Domain.Models.Classroom classroom)
    {
        var classEntity = _mapper.Map<DataContext.Entities.Classroom>(classroom);
        _unitOfWork.ClassRepository.Add(classEntity);

        await _unitOfWork.SaveChangesAsync();
        return _mapper.Map<Domain.Models.Classroom>(classEntity);
    }
}
