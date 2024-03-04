using Microsoft.AspNetCore.Mvc;

namespace Silicon_ASP.NET.Controllers;

public class authController : Controller
{
    [Route("/signup")]
    public IActionResult SignUp()
    {
        return View();
    }

}
