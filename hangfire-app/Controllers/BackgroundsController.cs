using Hangfire;
using hangfire_app.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace hangfire_app.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobsController : ControllerBase
    {
        readonly IEmailService _emailService;

        public JobsController(IEmailService emailService)
        {
            _emailService = emailService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            BackgroundJob.Enqueue(() => BackgroundServices.Test());
            return Ok("hangfire worked");
        }

        [HttpPost]
        public IActionResult Post(string email)
        {
            BackgroundJob.Enqueue(() => _emailService.SendEmailAsync(email));
            return Ok("Email sent to: " + email + " " + DateTime.Now);
        }
    }

    public class BackgroundServices
    {
        public static void Test()
        {
            Console.WriteLine("hangfire working " + DateTime.Now);
        }
    }
}
