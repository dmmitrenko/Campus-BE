using AutoMapper;
using Campus.Subject.Core.Interfaces;
using Campus.Subject.Domain.Models;
using Campus_Subject.API.Controllers.Base;
using Campus_Subject.API.Models.Requests;
using Microsoft.AspNetCore.Mvc;

namespace Campus_Subject.API.Controllers;
public class SubjectController : BaseController
{
    private readonly ISubjectService _subjectService;

    public SubjectController(
        IMapper mapper,
        ISubjectService subjectService) : base(mapper)
    {
        _subjectService = subjectService;
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    public async Task<IActionResult> AddSubject([FromBody] AddSubjectRequest request)
    {
        var subjectModel = _mapper.Map<LessonModel>(request);
        var subject = await _subjectService.AddSubjectAsync(subjectModel);

        return CreatedAtAction(nameof(AddSubject), subject);
    }
}
