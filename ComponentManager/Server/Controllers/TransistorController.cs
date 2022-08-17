using ComponentManager.Server.Data;
using ComponentManager.Shared;
using Microsoft.AspNetCore.Mvc;

namespace ComponentManager.Server.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class TransistorController : DefaultController<Transistor>
    {
        public TransistorController(ILogger<WeatherForecastController> logger, ApplicationDbContext context) : base(context)
        {

        }



        protected override void CopyTo(Transistor dst, Transistor src)
        {
            dst.Name = src.Name;
            dst.UMax = src.UMax;
        }

        protected override IQueryable<Transistor> Filter(IQueryable<Transistor> data, string filter)
        {
            return data.Where(a => a.Name.Contains(filter.First()));
        }
    }
}