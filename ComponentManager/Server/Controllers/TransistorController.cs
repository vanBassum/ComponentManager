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

        protected override int GetKey(Transistor item) => item.Id;

        protected override void CopyTo(Transistor dst, Transistor src)
        {
            dst.Name = src.Name;
            dst.UMax = src.UMax;
        }
    }
}