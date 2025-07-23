using Microsoft.AspNetCore.Mvc;
using OnionArchitecture.WebApi.Abstractions;

namespace OnionArchitecture.WebApi.Controllers
{

    public class ValuesController : BaseApiController
    {

        [HttpGet]
        public IActionResult Get()
        {
            var list = new List<string>
            {
                "ankara","izmir","istanbul"
            };

            return Ok(list);
        }
    }
}
