using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Conjure.BlazorAuth.Controllers
{
    public partial class SignInController : ControllerBase
    {
        public const string GetMethod = nameof(HttpMethods.Get);
        public const string PostMethod = nameof(HttpMethods.Post);

        private ILogger _logger;
        private UserManager<IdentityUser> _userManager;
        private SignInManager<IdentityUser> _signInManager;

        public SignInController(
            ILogger<SignInController> logger,
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager)
        {
            _logger = logger;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        // TODO:  these are temporary...

        [ActionName("ping")]
        [AcceptVerbs(GetMethod, PostMethod)]
        public IActionResult Ping()
        {
            return Ok("pong");
        }

        [ActionName("time")]
        [AcceptVerbs(GetMethod)]
        public IActionResult Time()
        {
            return Ok(DateTime.Now.ToString());
        }
    }
}
