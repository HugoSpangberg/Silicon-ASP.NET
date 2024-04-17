using Infrastructure.Entities;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Silicon_ASP.NET.ViewModels;
using System.Net.Http;
using System.Text;

namespace Silicon_ASP.NET.Controllers
{
    public class DefaultController(HttpClient httpClient) : Controller
    {
        private readonly HttpClient _httpClient = httpClient;

        [Route("/")]
        public IActionResult Home() => View();

        [Route("/error")]
        public IActionResult Error404(int statusCode) => View();


        [HttpPost]
        public async Task<IActionResult> Subscribe(SubscribeViewModel model)
        {
            if (ModelState.IsValid)
            {
                var content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
                var response = await _httpClient.PostAsync("https://localhost:7078/api/subscribers", content);
                if (response.IsSuccessStatusCode)
                {

                    TempData["StatusMessage"] = "You are now subscribed";
                    
                }
                else if (response.StatusCode == System.Net.HttpStatusCode.Conflict)
                {
                    TempData["StatusMessage"] = "You are already subscribed";
                    ViewBag.StatusClass = "warning";
                }

            }
            else
            {
                TempData["StatusMessage"] = "Invalid email address";
                ViewBag.StatusClass = "error";
            }
            return RedirectToAction("Home", "Default", "_newsletter");
        }
    }
}
