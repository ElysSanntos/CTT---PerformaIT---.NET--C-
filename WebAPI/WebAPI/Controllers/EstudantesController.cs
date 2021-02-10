using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI_Dominio;



namespace WebAPI.Controllers
{
    [Route("[controller]")]//dizer ao projeto qual o caminho - EndPoint - URL ==>A rota define a URL
    [ApiController]
    public class EstudantesController : ControllerBase
    {
        private readonly TabelaEstudante _tabelaEstudante;
        //Contrutor, tudo que eu epreciso que seja inicializado junto com a classe
        public EstudantesController()
        {
            _tabelaEstudante = new TabelaEstudante();
        }

        [HttpPost]
        public void Post([FromQuery]string cpf, string telefone)
        {
            Estudante estudante = new Estudante(cpf, telefone);
            _tabelaEstudante.IncluirEstudante(estudante);
        }
        [HttpGet("{id}")]
        public Estudante Get(int id)
        {
           return _tabelaEstudante.RetornaPeloID(id);
        }
    }
}
