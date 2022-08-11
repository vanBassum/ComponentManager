using ComponentManager.Shared;
using Microsoft.AspNetCore.Mvc;

namespace ComponentManager.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TransistorController : ControllerBase
    {
        private static readonly IEnumerable<string> Data = new[]
        {
            "BC107", "BC107A", "BC107B", "BC108", "BC108A", "BC108B", "BC108C", "BC109A", "BC109B", "BC109C", "BC140", "BC140-6", "BC140-10", "BC140-16", "BC141", "BC141-6", "BC141-10", "BC141-16", "BC160", "BC160-6", "BC160-10", "BC160-16", "BC161", "BC161-6", "BC161-10", "BC161-16", "BC177", "BC177A", "BC177B", "BC178", "BC178A", "BC178B", "BC178C", "BC179", "BC179B", "BC179C", "BC414", "BC414B", "BC414C", "BC416", "BC416B", "BC416C", "BC546", "BC546A", "BC546B", "BC547", "BC547A", "BC547B", "BC548", "BC548A", "BC548B", "BC548C", "BC549", "BC549B", "BC549C", "BC550", "BC550B", "BC550C", "BC556", "BC556A", "BC556B", "BC557", "BC557A", "BC557B", "BC558", "BC558A", "BC558B", "BC558C", "BC559", "BC559B", "BC559C", "BC560", "BC560B", "BC560C", "BD135", "BD135-6", "BD135-10", "BD135-16", "BD136", "BD136-6", "BD136-10", "BD136-16", "BD137", "BD137-6", "BD137-10", "BD138", "BD138-6", "BD138-10", "BD139", "BD139-6", "BD139-10", "BD140", "BD140-6", "BD140-10", "BD233", "BD234", "BD235", "BD236", "BD237", "BD238", "BD239", "BD239A", "BD239B", "BD239C", "BD240", "BD240A", "BD240B", "BD240C", "BD241", "BD241A", "BD241B", "BD241C", "BD242", "BD242A", "BD242B", "BD242C", "BD243", "BD243A", "BD243B", "BD243C", "BD244", "BD244A", "BD244B", "BD244C", "BD245", "BD245A", "BD245B", "BD245C", "BD246", "BD246A", "BD246B", "BD246C", "BD249", "BD249A", "BD249B", "BD249C", "BD250", "BD250A", "BD250B", "BD250C", "BD379", "BD380", "MJ2955", "MJE2955", "MJE3055", "2N3055"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public TransistorController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        public PagingInfo<string> Get(int? page, int? size)
        {
            page ??= 1;
            size ??= 10;
            var result = PagingInfo<string>.Create(Data, page.Value, size.Value);
            return result;
        }


    }
}