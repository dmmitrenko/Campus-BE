using AutoMapper;
using Campus.API.Controllers.Base;
using Campus.Core.Interfaces;
using Campus.Domain.Models;
using Campus.API.Models.Requests;
using Microsoft.AspNetCore.Mvc;
using Campus.API.Models.Responses;

namespace Campus.API.Controllers;
public class EducatorController : BaseController<EducatorController>
{
    private readonly IEducatorService _educatorService;

    public EducatorController(
        IMapper mapper,
        ILogger<EducatorController> logger,
        IEducatorService educatorService) : base(mapper, logger)
    {
        _educatorService = educatorService;
    }

    [HttpGet(GetEducatorByCodeRequest.Route)]
    [ProducesResponseType(typeof(GetEducatorByCodeResponse), 200)]
    public async Task<GetEducatorByCodeResponse> GetEducatorByCode([FromRoute] GetEducatorByCodeRequest request)
    {
        throw new NotImplementedException();
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    public async Task<AddEducatorResponse> AddEducator([FromBody] AddEducatorRequest request)
    {
        var educatorModel = Mapper.Map<Educator>(request);
        var educator = await _educatorService.AddTeacherAsync(educatorModel);

        return new AddEducatorResponse(educator);
    }

    [HttpGet(GetEducatorCoursesRequest.Route)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<GetEducatorCoursesResponse> GetEducatorCourses([FromBody] GetEducatorCoursesRequest request)
    {
        var courses = await _educatorService.GetTeacherLessonsAsync(request.EducatorId);

        return new GetEducatorCoursesResponse
        {
            Courses = courses,
        };
    }

    [HttpPost("subject")]
    public async Task<IActionResult> AddCourseForEducator([FromBody] AddCourseForEducatorRequest request)
    {
        var teacherLessonModel = Mapper.Map<EducatorCourse>(request);
        var teacherSubject = await _educatorService.AddTeacherLessonsAsync(teacherLessonModel);

        return CreatedAtAction(nameof(AddCourseForEducator), teacherSubject);
    }
}
