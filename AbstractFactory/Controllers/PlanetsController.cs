﻿using AbstractFactory.Business;
using Microsoft.AspNetCore.Mvc;

namespace AbstractFactory.Controllers
{
    [ApiController]
    [Route("planetas")]
    public class WeatherForecastController : ControllerBase
    {
        PlanetaBusiness _business = new PlanetaBusiness();

        [HttpGet]
        [Route("")]
        public string Get()
        {
            return _business.GetCsv();
        }
    }
}