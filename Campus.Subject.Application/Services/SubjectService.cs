﻿using AutoMapper;
using Campus.Subject.Core.Interfaces;
using Campus.Subject.DataContext.Entities;
using Campus.Subject.DataContext.Repositories.Interfaces;
using Campus.Subject.DataContext.Repositories.UoW;
using Campus.Subject.Domain.Models;
using Npgsql.TypeMapping;

namespace Campus.Subject.Application.Services;
public class SubjectService : ISubjectService
{
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IReadSubjectRepository _subjectRepository;
    private readonly IReadTeacherRepository _teacherRepository;

    public SubjectService(
        IMapper mapper, 
        IUnitOfWork unitOfWork,
        IReadSubjectRepository subjectRepository,
        IReadTeacherRepository teacherRepository)
    {
        _mapper = mapper;
        _unitOfWork = unitOfWork;
        _subjectRepository = subjectRepository;
        _teacherRepository = teacherRepository;
    }

    public async Task<LessonModel> AddSubjectAsync(LessonModel lessonModel)
    {
        var lesson = _mapper.Map<Lesson>(lessonModel);
        _unitOfWork.SubjectRepository.Add(lesson);
        await _unitOfWork.SaveChangesAsync();

        return _mapper.Map<LessonModel>(lesson);
    }

    public async Task<IEnumerable<TeacherModel>> GetTeachersForLessonAsync(Guid lessonId)
    {
        var subject = await _subjectRepository
            .GetSubjectWithTeachers(lessonId);

        if (subject is null)
            throw new NotImplementedException();

        var teachers = subject.TeacherLessons.Select(n => n.Teacher);

        return _mapper.Map<IEnumerable<TeacherModel>>(teachers);
    }
}