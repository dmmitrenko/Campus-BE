using AutoMapper;
using Campus.Subject.Core.Interfaces;
using Campus.Subject.DataContext.Entities;
using Campus.Subject.DataContext.Repositories.Interfaces;
using Campus.Subject.DataContext.Repositories.UoW;
using Campus.Subject.Domain.Models;

namespace Campus.Subject.Application.Services;
public class TeacherService : ITeacherService
{
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IReadTeacherRepository _teacherRepository;

    public TeacherService(
        IMapper mapper, 
        IUnitOfWork unitOfWork,
        IReadTeacherRepository teacherRepository)
    {
        _mapper = mapper;
        _unitOfWork = unitOfWork;
        _teacherRepository = teacherRepository;
    }

    public async Task<TeacherModel> AddTeacherAsync(TeacherModel teacherModel)
    {
        var teacher = _mapper.Map<Teacher>(teacherModel);
        
        _unitOfWork.TeacherRepository.Add(teacher);
        await _unitOfWork.SaveChangesAsync();

        return _mapper.Map<TeacherModel>(teacher);
    }

    public async Task<IEnumerable<Guid>> GetTeacherLessonsAsync(Guid teacherId)
    {
        var teacher = await _teacherRepository
            .FindByConditionWithIncludes(n => n.Id == teacherId, x => x.TeacherLessons);
        var subjectIds = teacher.TeacherLessons.Select(n => n.LessonId);

        return subjectIds;
    }

    public async Task<TeacherLessonsModel> AddTeacherLessonsAsync(TeacherLessonsModel teacherLessonsModel)
    {
        var teacherSubject = _mapper.Map<TeacherLessons>(teacherLessonsModel);

        _unitOfWork.TeacherSubjectRepository.Add(teacherSubject);
        await _unitOfWork.SaveChangesAsync();

        return _mapper.Map<TeacherLessonsModel>(teacherSubject);
    }
}
