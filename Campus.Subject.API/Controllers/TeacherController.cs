using AutoMapper;
using Campus.Subject.Application.Services;
using Campus.Subject.Core.Interfaces;
using Campus.Subject.Domain.Models;
using Campus_Subject.API.Controllers.Base;
using Campus_Subject.API.Models.Requests;
using Microsoft.AspNetCore.Mvc;

namespace Campus_Subject.API.Controllers;
public class TeacherController : BaseController
{
    private readonly IMapper _mapper;
    private readonly ITeacherService _teacherService;

    public TeacherController(
        IMapper mapper,
        ITeacherService teacherService) : base(mapper)
    {
        _mapper = mapper;
        _teacherService = teacherService;
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    public async Task<IActionResult> AddTeacher([FromBody] AddTeacherRequest request)
    {
        var teacherModel = _mapper.Map<TeacherModel>(request);
        var teacher = await _teacherService.AddTeacherAsync(teacherModel);

        return CreatedAtAction(nameof(AddTeacher), teacher);
    }

    [HttpGet("subjects")]
    public async Task<IActionResult> GetTeacherLessons([FromBody] GetTeacherLessonsRequest request)
    {
        throw new NotImplementedException();
    }

    [HttpPost("subject")]
    public async Task<IActionResult> AddSubjectForTeacher([FromBody] AddSubjectForTeacherRequest request)
    {
        var teacherLessonModel = _mapper.Map<TeacherLessonsModel>(request);
        var teacherSubject = await _teacherService.AddTeacherLessonsAsync(teacherLessonModel);

        return CreatedAtAction(nameof(AddSubjectForTeacher), teacherSubject);
    }
}
