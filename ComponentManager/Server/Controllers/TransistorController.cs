using ComponentManager.Server.Data;
using ComponentManager.Shared;
using Microsoft.AspNetCore.Mvc;

namespace ComponentManager.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TransistorController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly ApplicationDbContext _context;

        public TransistorController(ILogger<WeatherForecastController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;

            if (!_context.Transistors.Any())
            {
                _context.Transistors.AddRange(Transistor.Seed);
                _context.SaveChanges();
            }

        }

        public PagingInfo<Transistor> Get(int? page, int? size, string? filter, string? sort, bool? desc)
        {
            page ??= 0;
            size ??= 10;

            IQueryable<Transistor> data = _context.Transistors;
            if (filter != null)
                data = data.Where(a => a.Name.ToLower().Contains(filter.ToLower()));

            if (sort != null)
                data = data.OrderDynamic(sort, desc??false);
            
               
            var result = PagingInfo<Transistor>.Create(data, page.Value, size.Value);
            return result;
        }


        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Transistor item)
        {
            if(ModelState.IsValid)
            {
                _context.Add(item);
                await _context.SaveChangesAsync();
                return Ok();                   
            }
            return BadRequest();
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] Transistor item)
        {
            if (ModelState.IsValid)
            {
                Transistor dbItem = await _context.Transistors.FindAsync(item.Id);
                if (dbItem != null)
                {
                    dbItem.Name = item.Name;
                    dbItem.UMax = item.UMax;
                    _context.Update(dbItem);
                    await _context.SaveChangesAsync();
                    return Ok();
                }
            }
            return BadRequest();
        }



        [HttpDelete]
        public async Task<IActionResult> Delete(int? id)
        {
            Transistor dbItem = await _context.Transistors.FindAsync(id);
            if (dbItem != null)
            {
                _context.Remove(dbItem);
                await _context.SaveChangesAsync();
                return Ok();
            }
            return NotFound();
        }
    }
}