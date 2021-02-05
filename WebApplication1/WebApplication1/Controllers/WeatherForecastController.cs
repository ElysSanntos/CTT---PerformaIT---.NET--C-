using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }

        // pegar um obj especifico

        [HttpGet("{id}")]// Atributo verbo que define o tipo de solicitação--ID: atributo da lista
        public WeatherForecast Get (int id)//Retorna a classe
        {
            var rng = new Random();
            var lista = Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            }).ToList();

            return lista.ElementAt(id - 1);//-1: Indice 0, do elemento 
        }

        [HttpGet("teste/{nome}")]
        public string Get(string nome)
        {
            if (nome.ToLower() == nome)
                return "Olá, " + nome;
            else
                return "Não sei quem é você!" + nome;
        }

        [HttpPost]
        public IEnumerable<WeatherForecast> Post(int dias, int temperatura)
        {
            var rng = new Random();
            var lista = Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            }).ToList();
            lista.Add(new WeatherForecast { Date = DateTime.Now.AddDays(dias), TemperatureC = temperatura });
            return lista;
        }
    }
}
