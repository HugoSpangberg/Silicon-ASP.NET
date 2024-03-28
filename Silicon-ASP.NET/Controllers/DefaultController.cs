using Infrastructure.Entities;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace Silicon_ASP.NET.Controllers
{
    public class DefaultController : Controller
    {
        [Route("/")]
        public IActionResult Home() => View();

        [Route("/error")]
        public IActionResult Error404(int statusCode) => View();


        public IActionResult Subscribe()
        {
            ViewData["Subscribed"] = false;

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Subscribe(SubscribeEntity model)
        {
            if (ModelState.IsValid)
            {
                using var http = new HttpClient();
                var json = JsonConvert.SerializeObject(model);
                using var content = new StringContent(json, Encoding.UTF8, "application/json");
                var respone = await http.PostAsync("https://localhost:7078/api/subscribers", content);

                if (respone.IsSuccessStatusCode) 
                {
                    ViewData["Subscribed"] = true;
                }
            }
            return View();
        }
    }
}
