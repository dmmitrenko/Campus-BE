using AutoMapper;
using Campus.API.Controllers.Base;
using Campus.Core.Interfaces;
using Campus.Domain.Models;
using Campus.API.Models.Requests;
using Microsoft.AspNetCore.Mvc;

namespace Campus.API.Controllers;
public class CourseController : BaseController<CourseController>
{
    private readonly ICourseService _subjectService;

    public CourseController(
        IMapper mapper,
        ILogger<CourseController> logger,
        ICourseService subjectService) : base(mapper, logger)
    {
        _subjectService = subjectService;
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    public async Task<IActionResult> AddSubject([FromBody] AddSubjectRequest request)
    {
        var subjectModel = Mapper.Map<Course>(request);
        var subject = await _subjectService.AddSubjectAsync(subjectModel);

        return CreatedAtAction(nameof(AddSubject), subject);
    }

    [HttpGet("teachers")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> GetTeachersForSubject(Guid subjectId)
    {
        var teachers = await _subjectService.GetTeachersForLessonAsync(subjectId);

        return Ok(teachers);
    }
}
