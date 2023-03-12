using AutoMapper;
using Campus.Core.Interfaces;
using Campus.DataContext.Entities;
using Campus.DataContext.Repositories.Interfaces;
using Campus.DataContext.Repositories.UoW;
using Campus.Domain.Models;
using Npgsql.TypeMapping;

namespace Campus.Application.Services;
public class CourseService : ICourseService
{
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IReadCourseRepository _subjectRepository;
    private readonly IReadEducatorRepository _teacherRepository;

    public CourseService(
        IMapper mapper,
        IUnitOfWork unitOfWork,
        IReadCourseRepository subjectRepository,
        IReadEducatorRepository teacherRepository)
    {
        _mapper = mapper;
        _unitOfWork = unitOfWork;
        _subjectRepository = subjectRepository;
        _teacherRepository = teacherRepository;
    }

    public async Task<Domain.Models.Course> AddSubjectAsync(Domain.Models.Course lessonModel)
    {
        var lesson = _mapper.Map<DataContext.Entities.Course>(lessonModel);
        _unitOfWork.SubjectRepository.Add(lesson);
        await _unitOfWork.SaveChangesAsync();

        return _mapper.Map<Domain.Models.Course>(lesson);
    }

    public async Task<IEnumerable<Domain.Models.Educator>> GetTeachersForLessonAsync(Guid lessonId)
    {
        var subject = await _subjectRepository
            .GetSubjectWithTeachers(lessonId);

        if (subject is null)
            throw new NotImplementedException();

        var teachers = subject.TeacherLessons.Select(n => n.Teacher);

        return _mapper.Map<IEnumerable<Domain.Models.Educator>>(teachers);
    }
}
