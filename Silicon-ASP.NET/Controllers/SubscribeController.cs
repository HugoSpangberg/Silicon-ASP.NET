using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Silicon_ASP.NET.ViewModels;
using System.Text;

namespace Silicon_ASP.NET.Controllers
{
    public class SubscribeController(HttpClient httpClient) : Controller
    {
        private readonly HttpClient _httpClient = httpClient;

        public IActionResult Index()
        {

            return View();
        }


    }
}
