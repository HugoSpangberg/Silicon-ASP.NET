using Infrastructure.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Silicon_ASP.NET.Controllers
{
    [Authorize]
    public class CoursesController : Controller
    {
        [Route("/allcourses")]
        public async Task<IActionResult> AllCourses()
        {
            using var http = new HttpClient();
            var response = await http.GetAsync("https://localhost:7078/api/Courses");
            var json = await response.Content.ReadAsStringAsync();
            var data = JsonConvert.DeserializeObject<IEnumerable<CourseEntity>>(json);
            return View(data);
        }

        public async Task<IActionResult> Details()
        {
            using var http = new HttpClient();
            var response = await http.GetAsync("https://localhost:7078/api/Courses/3");
            var json = await response.Content.ReadAsStringAsync();
            var data = JsonConvert.DeserializeObject<CourseEntity>(json);
            return View(data);
        }
    }
}
