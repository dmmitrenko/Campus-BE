using AutoMapper;
using Campus.Subject.Core.Interfaces;
using Campus.Subject.DataContext.Entities;
using Campus.Subject.DataContext.Repositories.UoW;
using Campus.Subject.Domain.Models;

namespace Campus.Subject.Application.Services;
public class ClassroomService : IClassroomService
{
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;

    public ClassroomService(
        IMapper mapper,
        IUnitOfWork unitOfWork)
    {
        _mapper = mapper;
        _unitOfWork = unitOfWork;
    }

    public async Task<ClassroomModel> AddClassroomAsync(ClassroomModel classroom)
    {
        var classEntity = _mapper.Map<Classroom>(classroom);
        _unitOfWork.ClassRepository.Add(classEntity);

        await _unitOfWork.SaveChangesAsync();
        return _mapper.Map<ClassroomModel>(classEntity);
    }
}
