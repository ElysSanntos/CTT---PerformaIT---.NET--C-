using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("feira")]
    [ApiController]
    public class TesteController : ControllerBase
    {
        [HttpGet("banana")]
        public string GetB()
        {
            return "olá banana!";
        }

        [HttpGet("goiaba")]
        public string GetG()
        {
            return "olá goiaba!";
        }

        [HttpGet]
        public string Get()
        {
            return "olá Pessoa!";
        }

        [HttpGet("{fruta}")]
        public string GetF(string fruta)
        {
            return $"olá {fruta}!";
        }
    }
}
