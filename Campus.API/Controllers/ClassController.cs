using AutoMapper;
using Campus.API.Controllers.Base;
using Campus.Core.Interfaces;
using Campus.Domain.Models;
using Campus.API.Models.Requests;
using Microsoft.AspNetCore.Mvc;

namespace Campus.API.Controllers;

public class ClassController : BaseController<ClassController>
{
    private readonly IClassService _classService;

    public ClassController(
        IMapper mapper,
        ILogger<ClassController> logger,
        IClassService classService) : base(mapper, logger)
    {
        _classService = classService;
    }

    [HttpPost]
    public async Task<IActionResult> AddClassroom([FromBody] AddClassroomRequest request)
    {
        var classModel = Mapper.Map<Classroom>(request);
        var classroom = await _classService.AddClassroomAsync(classModel);

        return CreatedAtAction(nameof(AddClassroom), classroom);
    }
}
