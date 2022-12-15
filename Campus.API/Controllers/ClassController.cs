using AutoMapper;
using Campus.API.Controllers.Base;
using Campus.Core.Interfaces;
using Campus.Domain.Models;
using Campus.API.Models.Requests;
using Microsoft.AspNetCore.Mvc;

namespace Campus.API.Controllers;

public class ClassController : BaseController
{
    private readonly IClassroomService _classService;

    public ClassController(
        IMapper mapper,
        IClassroomService classService) : base(mapper)
    {
        _classService = classService;
    }

    [HttpPost]
    public async Task<IActionResult> AddClassroom([FromBody] AddClassroomRequest request)
    {
        var classModel = _mapper.Map<ClassroomModel>(request);
        var classroom = await _classService.AddClassroomAsync(classModel);

        return CreatedAtAction(nameof(AddClassroom), classroom);
    }
}
