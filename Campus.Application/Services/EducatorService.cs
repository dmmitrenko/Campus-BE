using AutoMapper;
using Campus.Core.Interfaces;
using Campus.DataContext.Entities;
using Campus.DataContext.Repositories.Interfaces;
using Campus.DataContext.Repositories.UoW;
using Campus.Domain.Exceptions;
using Campus.Domain.Models;

namespace Campus.Application.Services;
public class EducatorService : IEducatorService
{
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IReadEducatorRepository _teacherRepository;
    private readonly IReadCourseRepository _subjectRepository;

    public EducatorService(
        IMapper mapper,
        IUnitOfWork unitOfWork,
        IReadEducatorRepository teacherRepository,
        IReadCourseRepository subjectRepository)
    {
        _mapper = mapper;
        _unitOfWork = unitOfWork;
        _teacherRepository = teacherRepository;
        _subjectRepository = subjectRepository;
    }

    public async Task<Domain.Models.Educator> AddTeacherAsync(Domain.Models.Educator teacherModel)
    {
        var teacher = _mapper.Map<DataContext.Entities.Educator>(teacherModel);

        _unitOfWork.TeacherRepository.Add(teacher);
        await _unitOfWork.SaveChangesAsync();

        return _mapper.Map<Domain.Models.Educator>(teacher);
    }

    public async Task<IEnumerable<Domain.Models.Course>> GetTeacherLessonsAsync(Guid teacherId)
    {
        var teacher = await _teacherRepository.GetTeacherWithSubjects(teacherId);

        if (teacher is null)
            throw new NotFoundException($"The teacher with this ID: {teacherId} was not found");

        var subjects = teacher.TeacherLessons.Select(x => x.Lesson);
        return _mapper.Map<IEnumerable<Domain.Models.Course>>(subjects);
    }

    public async Task<Domain.Models.EducatorCourse> AddTeacherLessonsAsync(Domain.Models.EducatorCourse teacherLessonsModel)
    {
        var teacherSubject = _mapper.Map<DataContext.Entities.EducatorCourse>(teacherLessonsModel);

        _unitOfWork.TeacherSubjectRepository.Add(teacherSubject);
        await _unitOfWork.SaveChangesAsync();

        return _mapper.Map<Domain.Models.EducatorCourse>(teacherSubject);
    }
}
