using Microsoft.AspNetCore.Mvc;

namespace Conjure.BlazorAuth.Controllers
{
    public partial class SignInController
    {
        [ActionName("signout")]
        [AcceptVerbs(PostMethod)]
        public async Task<IActionResult> DoSignOut()
        {
            await _signInManager.SignOutAsync();
            return NoContent();
        }
    }
}
