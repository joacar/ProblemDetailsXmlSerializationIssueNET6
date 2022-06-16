using System.Net.Mime;
using Microsoft.AspNetCore.Mvc;

namespace ProblemDetailsXMLSerialization
{
    [ApiController]
    [Route("[controller]")]
    public class XmlController : ControllerBase
    {
        [HttpPost]
        [Produces(MediaTypeNames.Application.Xml)]
        [Consumes(MediaTypeNames.Application.Xml)]
        public IActionResult Xml()
        {
            return Problem();
        }
    }
}
