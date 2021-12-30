using Microsoft.AspNetCore.Mvc;

namespace BoilerPlatte.Host.Controllers;

[ApiController]
[Route("api/v{version:apiVersion}/[controller]")]
public class BaseController : ControllerBase
{
}
