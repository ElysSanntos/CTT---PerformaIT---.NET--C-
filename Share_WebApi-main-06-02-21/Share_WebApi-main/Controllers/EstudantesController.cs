using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WebAPI.Dominio;

namespace WebAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EstudantesController : ControllerBase
    {
        private static TabelaEstudante _tabelaEstudante = new TabelaEstudante();
        private static List<Estudante> estudantes = new List<Estudante>();
        public EstudantesController()
        {
        }

        [HttpPost]
        public void Post([FromQuery]string cpf, string telefone)
        {
            Estudante estudante = new Estudante(cpf, telefone);
            Incluir(estudante);
        }

        [HttpGet("{id}")]
        public Estudante Get(int id)
        {
            return RetornarPeloId(id);
        }

        private void Incluir(Estudante estudante)
        {
            int id = 0;
            var ultimoEstudante = estudantes.LastOrDefault();
            if (ultimoEstudante == null)
                id = 1;
            else
                id = ultimoEstudante.Id + 1;
            estudante.Id = id;
            estudantes.Add(estudante);
        }

        private Estudante RetornarPeloId(int id)
        {
            return estudantes.FirstOrDefault(e => e.Id == id);
        }
    }
}
