using Microsoft.AspNetCore.Mvc;
using Silicon_ASP.NET.Models.Sections;
using Silicon_ASP.NET.Models.Views;

namespace Silicon_ASP.NET.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var viewModel = new HomeIndexViewModel
        {
            Title = "Home",
            Showcase = new ShowcaseViewModel
            {
                Id = "showcase",
                ShowcaseImage = new() { ImageUrl = "/images/taskmaster-image.png", AltText = "Task Management Assistant" },
                Title = "Task Management Assistant You Gonna Love",
                Text = "We offer you a new generation of task management system. Plan, manage & track all your tasks in one flexible tool.",
                BrandsText = "Largest companies use our tool to work efficiently",
                Link = new() { ControllerName = "Download", ActionName = "Index", Text = "Get started for free" },

                Brands =
                [
                    new() { ImageUrl = "/images/brand_1.svg", AltText = "Brand Name 1" },
                    new() { ImageUrl = "/images/brand_2.svg", AltText = "Brand Name 2" },
                    new() { ImageUrl = "/images/brand_3.svg", AltText = "Brand Name 3" },
                    new() { ImageUrl = "/images/brand_4.svg", AltText = "Brand Name 4" },

                ],
            }
        };
        ViewData["Title"] = viewModel.Title;
        return View(viewModel);
    }
}
