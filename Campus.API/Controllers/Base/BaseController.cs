using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace Campus.API.Controllers.Base;

public abstract class BaseController<TController> : Controller where TController : BaseController<TController>
{

    protected BaseController(IMapper mapper, ILogger<TController> logger)
    {
        Mapper = mapper;
        Logger = logger;
    }

    public IMapper Mapper { get; }
    public ILogger<TController> Logger { get; }
}
