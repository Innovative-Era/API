using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Palindrom.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValidateController : ControllerBase
    {
        // GET: api/Validate
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("");
        }

        // GET: api/Validate/5
        [HttpGet("{ValidationText}", Name = "Get")]
        public IActionResult Get(string ValidationText)
        {
            try
            {
                if (string.IsNullOrEmpty(ValidationText))
                {
                    return NotFound();
                }
                var r = ValidationText.ToCharArray().Reverse();
                var s = string.Join("",r);
                if (ValidationText.Equals(s))
                {
                    return Ok("Pelindrom");
                }
                else {
                    return Ok("Not a pelindrom");
                }
            }
            catch (Exception e)
            {
                return NotFound();
            }
        }
    }
}
