using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace Campus.API.Controllers.Base;

[ApiController]
[Route("api/[controller]")]
public abstract class BaseController : Controller
{
    protected readonly IMapper _mapper;

    protected BaseController(IMapper mapper)
    {
        _mapper = mapper;
    }
}
