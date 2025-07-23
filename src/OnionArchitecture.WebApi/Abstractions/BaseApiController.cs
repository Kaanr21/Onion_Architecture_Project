using Microsoft.AspNetCore.Mvc;

namespace OnionArchitecture.WebApi.Abstractions
{
    //[Route("api/[controller]/[action]")] => Full Api Name
    [Route("[action]")]
    [ApiController]
    public class BaseApiController : ControllerBase
    {
    }
}
