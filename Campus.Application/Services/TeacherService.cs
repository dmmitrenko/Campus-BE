using AutoMapper;
using Campus.Core.Interfaces;
using Campus.DataContext.Entities;
using Campus.DataContext.Repositories.Interfaces;
using Campus.DataContext.Repositories.UoW;
using Campus.Domain.Exceptions;
using Campus.Domain.Models;

namespace Campus.Application.Services;
public class TeacherService : ITeacherService
{
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IReadTeacherRepository _teacherRepository;
    private readonly IReadSubjectRepository _subjectRepository;

    public TeacherService(
        IMapper mapper,
        IUnitOfWork unitOfWork,
        IReadTeacherRepository teacherRepository,
        IReadSubjectRepository subjectRepository)
    {
        _mapper = mapper;
        _unitOfWork = unitOfWork;
        _teacherRepository = teacherRepository;
        _subjectRepository = subjectRepository;
    }

    public async Task<TeacherModel> AddTeacherAsync(TeacherModel teacherModel)
    {
        var teacher = _mapper.Map<Teacher>(teacherModel);

        _unitOfWork.TeacherRepository.Add(teacher);
        await _unitOfWork.SaveChangesAsync();

        return _mapper.Map<TeacherModel>(teacher);
    }

    public async Task<IEnumerable<LessonModel>> GetTeacherLessonsAsync(Guid teacherId)
    {
        var teacher = await _teacherRepository.GetTeacherWithSubjects(teacherId);

        if (teacher is null)
            throw new TeacherNotFoundException(teacherId);

        var subjects = teacher.TeacherLessons.Select(x => x.Lesson);
        return _mapper.Map<IEnumerable<LessonModel>>(subjects);
    }

    public async Task<TeacherLessonsModel> AddTeacherLessonsAsync(TeacherLessonsModel teacherLessonsModel)
    {
        var teacherSubject = _mapper.Map<TeacherLessons>(teacherLessonsModel);

        _unitOfWork.TeacherSubjectRepository.Add(teacherSubject);
        await _unitOfWork.SaveChangesAsync();

        return _mapper.Map<TeacherLessonsModel>(teacherSubject);
    }
}
