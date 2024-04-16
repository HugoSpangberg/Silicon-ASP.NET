using Infrastructure.Context;
using Infrastructure.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Silicon_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscribersController(ApiDbContext context) : ControllerBase
    {
        private readonly ApiDbContext _context = context;

        [HttpPost]
        public async Task<IActionResult> Create(SubscribeEntity entity)
        {
            if (ModelState.IsValid)
            {
                if (!await _context.Subscribers.AnyAsync(x => x.Email == entity.Email))
                {
                    try
                    {
                        var subscriberEntity = new SubscribeEntity 
                        { 
                            Email = entity.Email,
                            DailyNewsletter = entity.DailyNewsletter,
                            AdvertisingUpdate = entity.AdvertisingUpdate,
                            WeekInReview = entity.WeekInReview,
                            EventUpdates = entity.EventUpdates,
                            StartupsWeekly = entity.StartupsWeekly,
                            Podcasts = entity.Podcasts

                        };
                        _context.Subscribers.Add(subscriberEntity);
                        await _context.SaveChangesAsync();
                        return Created("", null);
                    }
                    catch 
                    {
                        return Problem("Unable to create subscription");
                    }
                }
                return Conflict("Email address already subscribed");
            }
            return BadRequest();
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var subscribers = await _context.Subscribers.ToListAsync();
            if (subscribers.Count != 0)
            {
                return Ok(subscribers);
            }
            return NotFound();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetOne(int id)
        {
            var subscribers = await _context.Subscribers.FirstOrDefaultAsync(x => x.Id == id);
            if (subscribers != null)
            {
                return Ok(subscribers);

            }
            return NotFound();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateOne(int id, string email)
        {
            var subscribers = await _context.Subscribers.FirstOrDefaultAsync(x => x.Id == id);
            if (subscribers != null)
            {
                subscribers.Email = email;
                _context.Subscribers.Update(subscribers);
                await _context.SaveChangesAsync();
                return Ok(subscribers);

            }
            return NotFound();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOne(int id)
        {
            var subscribers = await _context.Subscribers.FirstOrDefaultAsync(x => x.Id == id);
            if (subscribers != null)
            {
                _context.Subscribers.Remove(subscribers);
                await _context.SaveChangesAsync();
                return Ok();

            }
            return NotFound();
        }
    }
}
