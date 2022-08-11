﻿using ComponentManager.Shared;
using Microsoft.AspNetCore.Mvc;

namespace ComponentManager.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TransistorController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;

        public TransistorController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        public PagingInfo<Transistor> Get(int? page, int? size, string? filter)
        {
            page ??= 0;
            size ??= 10;

            var data = DB;
            if (filter != null)
                data = data.Where(a => a.Name.ToLower().Contains(filter.ToLower()));
            var result = PagingInfo<Transistor>.Create(data, page.Value, size.Value);
            return result;
        }






        private static readonly IEnumerable<Transistor> DB = new[]
        {
            new Transistor{Name = "BC107", UMax = 45 },
new Transistor{Name = "BC107A", UMax = 45 },
new Transistor{Name = "BC107B", UMax = 45 },
new Transistor{Name = "BC108", UMax = 20 },
new Transistor{Name = "BC108A", UMax = 20 },
new Transistor{Name = "BC108B", UMax = 20 },
new Transistor{Name = "BC108C", UMax = 20 },
new Transistor{Name = "BC109A", UMax = 20 },
new Transistor{Name = "BC109B", UMax = 20 },
new Transistor{Name = "BC109C", UMax = 20 },
new Transistor{Name = "BC140", UMax = 40 },
new Transistor{Name = "BC140-6", UMax = 40 },
new Transistor{Name = "BC140-10", UMax = 40 },
new Transistor{Name = "BC140-16", UMax = 40 },
new Transistor{Name = "BC141", UMax = 60 },
new Transistor{Name = "BC141-6", UMax = 60 },
new Transistor{Name = "BC141-10", UMax = 60 },
new Transistor{Name = "BC141-16", UMax = 60 },
new Transistor{Name = "BC160", UMax = 40 },
new Transistor{Name = "BC160-6", UMax = 40 },
new Transistor{Name = "BC160-10", UMax = 40 },
new Transistor{Name = "BC160-16", UMax = 40 },
new Transistor{Name = "BC161", UMax = 60 },
new Transistor{Name = "BC161-6", UMax = 60 },
new Transistor{Name = "BC161-10", UMax = 60 },
new Transistor{Name = "BC161-16", UMax = 60 },
new Transistor{Name = "BC177", UMax = 45 },
new Transistor{Name = "BC177A", UMax = 45 },
new Transistor{Name = "BC177B", UMax = 45 },
new Transistor{Name = "BC178", UMax = 25 },
new Transistor{Name = "BC178A", UMax = 25 },
new Transistor{Name = "BC178B", UMax = 25 },
new Transistor{Name = "BC178C", UMax = 25 },
new Transistor{Name = "BC179", UMax = 20 },
new Transistor{Name = "BC179B", UMax = 20 },
new Transistor{Name = "BC179C", UMax = 20 },
new Transistor{Name = "BC414", UMax = 45 },
new Transistor{Name = "BC414B", UMax = 45 },
new Transistor{Name = "BC414C", UMax = 45 },
new Transistor{Name = "BC416", UMax = 45 },
new Transistor{Name = "BC416B", UMax = 45 },
new Transistor{Name = "BC416C", UMax = 45 },
new Transistor{Name = "BC546", UMax = 65 },
new Transistor{Name = "BC546A", UMax = 65 },
new Transistor{Name = "BC546B", UMax = 65 },
new Transistor{Name = "BC547", UMax = 45 },
new Transistor{Name = "BC547A", UMax = 45 },
new Transistor{Name = "BC547B", UMax = 45 },
new Transistor{Name = "BC548", UMax = 30 },
new Transistor{Name = "BC548A", UMax = 30 },
new Transistor{Name = "BC548B", UMax = 30 },
new Transistor{Name = "BC548C", UMax = 30 },
new Transistor{Name = "BC549", UMax = 30 },
new Transistor{Name = "BC549B", UMax = 30 },
new Transistor{Name = "BC549C", UMax = 30 },
new Transistor{Name = "BC550", UMax = 45 },
new Transistor{Name = "BC550B", UMax = 45 },
new Transistor{Name = "BC550C", UMax = 45 },
new Transistor{Name = "BC556", UMax = 65 },
new Transistor{Name = "BC556A", UMax = 65 },
new Transistor{Name = "BC556B", UMax = 65 },
new Transistor{Name = "BC557", UMax = 45 },
new Transistor{Name = "BC557A", UMax = 45 },
new Transistor{Name = "BC557B", UMax = 45 },
new Transistor{Name = "BC558", UMax = 30 },
new Transistor{Name = "BC558A", UMax = 30 },
new Transistor{Name = "BC558B", UMax = 30 },
new Transistor{Name = "BC558C", UMax = 30 },
new Transistor{Name = "BC559", UMax = 30 },
new Transistor{Name = "BC559B", UMax = 30 },
new Transistor{Name = "BC559C", UMax = 30 },
new Transistor{Name = "BC560", UMax = 45 },
new Transistor{Name = "BC560B", UMax = 45 },
new Transistor{Name = "BC560C", UMax = 45 },
new Transistor{Name = "BD135", UMax = 45 },
new Transistor{Name = "BD135-6", UMax = 45 },
new Transistor{Name = "BD135-10", UMax = 45 },
new Transistor{Name = "BD135-16", UMax = 45 },
new Transistor{Name = "BD136", UMax = 45 },
new Transistor{Name = "BD136-6", UMax = 45 },
new Transistor{Name = "BD136-10", UMax = 45 },
new Transistor{Name = "BD136-16", UMax = 45 },
new Transistor{Name = "BD137", UMax = 60 },
new Transistor{Name = "BD137-6", UMax = 60 },
new Transistor{Name = "BD137-10", UMax = 60 },
new Transistor{Name = "BD138", UMax = 60 },
new Transistor{Name = "BD138-6", UMax = 60 },
new Transistor{Name = "BD138-10", UMax = 60 },
new Transistor{Name = "BD139", UMax = 80 },
new Transistor{Name = "BD139-6", UMax = 80 },
new Transistor{Name = "BD139-10", UMax = 80 },
new Transistor{Name = "BD140", UMax = 80 },
new Transistor{Name = "BD140-6", UMax = 80 },
new Transistor{Name = "BD140-10", UMax = 80 },
new Transistor{Name = "BD233", UMax = 45 },
new Transistor{Name = "BD234", UMax = 45 },
new Transistor{Name = "BD235", UMax = 60 },
new Transistor{Name = "BD236", UMax = 60 },
new Transistor{Name = "BD237", UMax = 80 },
new Transistor{Name = "BD238", UMax = 80 },
new Transistor{Name = "BD239", UMax = 45 },
new Transistor{Name = "BD239A", UMax = 60 },
new Transistor{Name = "BD239B", UMax = 80 },
new Transistor{Name = "BD239C", UMax = 100 },
new Transistor{Name = "BD240", UMax = 45 },
new Transistor{Name = "BD240A", UMax = 60 },
new Transistor{Name = "BD240B", UMax = 80 },
new Transistor{Name = "BD240C", UMax = 100 },
new Transistor{Name = "BD241", UMax = 45 },
new Transistor{Name = "BD241A", UMax = 60 },
new Transistor{Name = "BD241B", UMax = 80 },
new Transistor{Name = "BD241C", UMax = 100 },
new Transistor{Name = "BD242", UMax = 45 },
new Transistor{Name = "BD242A", UMax = 60 },
new Transistor{Name = "BD242B", UMax = 80 },
new Transistor{Name = "BD242C", UMax = 100 },
new Transistor{Name = "BD243", UMax = 45 },
new Transistor{Name = "BD243A", UMax = 60 },
new Transistor{Name = "BD243B", UMax = 80 },
new Transistor{Name = "BD243C", UMax = 100 },
new Transistor{Name = "BD244", UMax = 45 },
new Transistor{Name = "BD244A", UMax = 60 },
new Transistor{Name = "BD244B", UMax = 80 },
new Transistor{Name = "BD244C", UMax = 100 },
new Transistor{Name = "BD245", UMax = 45 },
new Transistor{Name = "BD245A", UMax = 60 },
new Transistor{Name = "BD245B", UMax = 80 },
new Transistor{Name = "BD245C", UMax = 100 },
new Transistor{Name = "BD246", UMax = 45 },
new Transistor{Name = "BD246A", UMax = 60 },
new Transistor{Name = "BD246B", UMax = 80 },
new Transistor{Name = "BD246C", UMax = 100 },
new Transistor{Name = "BD249", UMax = 45 },
new Transistor{Name = "BD249A", UMax = 60 },
new Transistor{Name = "BD249B", UMax = 80 },
new Transistor{Name = "BD249C", UMax = 100 },
new Transistor{Name = "BD250", UMax = 45 },
new Transistor{Name = "BD250A", UMax = 60 },
new Transistor{Name = "BD250B", UMax = 80 },
new Transistor{Name = "BD250C", UMax = 100 },
new Transistor{Name = "BD379", UMax = 80 },
new Transistor{Name = "BD380", UMax = 80 },
new Transistor{Name = "MJ2955", UMax = 60 },
new Transistor{Name = "MJE2955", UMax = 60 },
new Transistor{Name = "MJE3055", UMax = 60 },
new Transistor{Name = "2N3055", UMax = 60 },
        };
    }
}