using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SparkPlug.Core;
using SparkPlug.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SparkPlug.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeedbackController : ControllerBase
    {
        private readonly FeedbackService _service;
        public FeedbackController(FeedbackService service)
        {
            _service = service;
        }

        [HttpPost("")]
        public IActionResult Post([FromBody]Feedback feedback)
        {
            try
            {
                _service.InsertData(feedback);
                return Ok(new { success = true, message = "successful" });
            }
            catch (Exception ex)
            {
                return Ok(new { success = false, message = ex.Message });
            }
        }

        [HttpGet("")]
        public IActionResult Get()
        {
            return Ok();
        }
    }
}
