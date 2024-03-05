using Microsoft.AspNetCore.Mvc;
using Silicon_ASP.NET.ViewModels.Sections;

namespace Silicon_ASP.NET.Controllers;

public class authController : Controller
{
    [Route("/signup")]
    [HttpGet]
    public IActionResult SignUp()
    {
        var viewModel = new SignUpViewModel();
        return View(viewModel);
    }


    [Route("/signup")]
    [HttpPost]
    public IActionResult SignUp(SignUpViewModel viewModel)
    {
        if (!ModelState.IsValid)
        return View(viewModel);

        return RedirectToAction("SignIn", "Auth");
    }



}
