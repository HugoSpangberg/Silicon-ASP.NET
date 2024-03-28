using Infrastructure.Context;
using Infrastructure.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Silicon_WebAPI.Dtos;

namespace Silicon_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController(ApiDbContext context) : ControllerBase
    {

        private readonly ApiDbContext _context = context;

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _context.Courses.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetOne(int id)
        {
            var course = await _context.Courses.FirstOrDefaultAsync(x => x.Id == id);
            if (course != null)
            {
                return Ok(course);
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> CreateOne(CourseDto dto)
        {
            if (ModelState.IsValid)
            {
                var courseEntity = new CourseEntity
                {
                    Title = dto.Title,
                    Price = dto.Price,
                    DiscountPrice = dto.DiscountPrice,
                    Hours = dto.Hours,
                    IsBestSeller = dto.IsBestSeller,
                    LikesInNumbers = dto.LikesInNumbers,
                    LikesInProcent = dto.LikesInProcent,
                    Author = dto.Author
                };

                _context.Courses.Add(courseEntity);
                await _context.SaveChangesAsync();
                return Created("", courseEntity);

            }

            return BadRequest(dto);
        }


    }
}
