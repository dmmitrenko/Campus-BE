using AutoMapper;
using Campus.API.Controllers.Base;
using Campus.Core.Interfaces;
using Campus.Domain.Models;
using Campus.API.Models.Requests;
using Microsoft.AspNetCore.Mvc;

namespace Campus.API.Controllers;
public class TeacherController : BaseController
{
    private readonly ITeacherService _teacherService;

    public TeacherController(
        IMapper mapper,
        ITeacherService teacherService) : base(mapper)
    {
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
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> GetTeacherLessons(Guid teacherId)
    {
        var subjects = await _teacherService.GetTeacherLessonsAsync(teacherId);

        return Ok(subjects);
    }

    [HttpPost("subject")]
    public async Task<IActionResult> AddSubjectForTeacher([FromBody] AddSubjectForTeacherRequest request)
    {
        var teacherLessonModel = _mapper.Map<TeacherLessonsModel>(request);
        var teacherSubject = await _teacherService.AddTeacherLessonsAsync(teacherLessonModel);

        return CreatedAtAction(nameof(AddSubjectForTeacher), teacherSubject);
    }
}
