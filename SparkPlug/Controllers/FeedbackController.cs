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
                // validate feedback data before inserting data
                var validation = _service.ValidateFeedback(feedback);
                if (validation != null)
                    return Ok(new { success = false, message = validation });

                // insert data
                _service.InsertData(feedback);

                // return success message
                return Ok(new { success = true, message = "successful" });
            }
            catch (Exception ex)
            {
                // catch and return error
                return Ok(new { success = false, message = ex.Message });
            }
        }

    }
}
