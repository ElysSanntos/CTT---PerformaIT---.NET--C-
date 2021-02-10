using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
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

        [HttpGet] //Define o tipo de solicitação
        public IEnumerable<WeatherForecast> GetTeste()// retorno é uma coleção da classe WeatherForecast
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

        //Pegar um obj especifico:
        [HttpGet("{id}")]//passagem de patametro por metodo
        public WeatherForecast Get(int id)//assinatura do metodo que irá retornar um obj
        {
            var rng = new Random();
            var lista = Enumerable.Range(1, 5).Select(Index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(Index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]

            }).ToList();

            return lista.ElementAt(id - 1);//pega o elemento da posição informada na URL -1
        }

        [HttpGet("teste/{nome}")]

        public string Get(string nome)
        {
            if (nome.ToLower() == "thaise")
                return $"Olá {nome.ToUpper()}";
            else
                return $"Não sei quem é você, {nome.ToUpper()}!";
        }

        [HttpPost]
        public IEnumerable<WeatherForecast> Post(int dias, int temperatura)
        {
            var rng = new Random();
            var lista = Enumerable.Range(1, 5).Select(Index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(Index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]

            }).ToList();
            lista.Add(new WeatherForecast { Date = DateTime.Now.AddDays(dias), TemperatureC = temperatura });
            return lista;

        }

    }
}


