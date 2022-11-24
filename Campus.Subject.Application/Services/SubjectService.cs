using AutoMapper;
using Campus.Subject.Core.Interfaces;
using Campus.Subject.DataContext.Entities;
using Campus.Subject.DataContext.Repositories.UoW;
using Campus.Subject.Domain.Models;
using Npgsql.TypeMapping;

namespace Campus.Subject.Application.Services;
public class SubjectService : ISubjectService
{
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;

    public SubjectService(
        IMapper mapper, 
        IUnitOfWork unitOfWork)
    {
        _mapper = mapper;
        _unitOfWork = unitOfWork;
    }

    public async Task<LessonModel> AddSubjectAsync(LessonModel lessonModel)
    {
        var lesson = _mapper.Map<Lesson>(lessonModel);
        _unitOfWork.SubjectRepository.Add(lesson);
        await _unitOfWork.SaveChangesAsync();

        return _mapper.Map<LessonModel>(lesson);
    }
}
