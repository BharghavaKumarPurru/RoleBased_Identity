using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace RoleBased.Controllers
{
    [Authorize]
    public class LoginController : Controller
    {
        public IActionResult Display()
        {
            return View();
        }
    }
}
