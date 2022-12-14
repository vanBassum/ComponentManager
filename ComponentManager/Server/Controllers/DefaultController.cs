using ComponentManager.Server.Data;
using ComponentManager.Shared;
using Microsoft.AspNetCore.Mvc;

namespace ComponentManager.Server.Controllers
{
    public abstract class DefaultController<T> : ControllerBase where T : class
    {
        private readonly ApplicationDbContext _context;
        public DefaultController(ApplicationDbContext context)
        {
            _context = context;
        }

        protected abstract void CopyTo(T dst, T src);

        protected abstract int GetKey(T item);


        public PagingInfo<T> Get(int? page, int? size, string? filter, string? sort, bool? desc)
        {
            page ??= 0;
            size ??= 10;

            IQueryable<T> data = _context.Set<T>();
            if (filter != null)
                data = data.Where(a => a.ToString().ToLower().Contains(filter.ToLower()));

            if (sort != null)
                data = data.OrderDynamic(sort, desc ?? false);

            var result = PagingInfo<T>.Create(data, page.Value, size.Value);
            return result;
        }


        [HttpPost]
        public async Task<IActionResult> Create([FromBody] T item)
        {
            if (ModelState.IsValid)
            {
                _context.Add(item);
                await _context.SaveChangesAsync();
                return Ok();
            }
            return BadRequest();
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] T item)
        {
            if (ModelState.IsValid)
            {
                T dbItem = await _context.FindAsync<T>(GetKey(item));
                if (dbItem != null)
                {
                    CopyTo(dbItem, item);
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