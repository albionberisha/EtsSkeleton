using Ets.Services.IService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Authorization;

namespace Ets.Controllers
{
    [ApiController]
    public class ExamController : Controller
    {
        private readonly IExamService _categoryService;
        private readonly ILogger<ExamController> _logger;
        private readonly IStringLocalizer<ExamController> _localizer;
        private readonly IEmailSender _emailSender;

        public ExamController(IExamService categoryService, ILogger<ExamController> logger, IStringLocalizer<ExamController> localizer, IEmailSender emailSender)
        {
            _categoryService = categoryService;
            _logger = logger;
            _localizer = localizer;
            _emailSender = emailSender;
        }

        [HttpGet("GetExam")]
        [Authorize(Roles = "LifeUser")]
        public async Task<IActionResult> GetExam()
        {
            return Ok();
        }

        [HttpPost("CreateExam")]
        [Authorize(Roles = "LifeAdmin")]
        public async Task<IActionResult> CreateExam()
        {
            return Ok();
        }
    }
}
