using System.Collections.Generic;
using System.Threading.Tasks;
using GCarvalho.Data;
using GCarvalho.Data.Conf;
using Microsoft.AspNetCore.Mvc;

namespace GCarvalho.Controllers
{
    [ApiController]
    [Route("aeronave")]
    public class OrdemServicoController : ControllerBase
    {
        protected LuthieriaContext _context;
        private IInsturmentoRepository _insturmentoRepository;

        public OrdemServicoController(IInsturmentoRepository instrumentoRepository)
        {
             instrumentoRepository = _insturmentoRepository;

        }

        [HttpGet]
        public IEnumerable<Instrumento> Get()
        {
            return null;
        }

        [HttpGet("selecionar/{id}")]
        public Instrumento Buscar(int id)
        {
            return null;
        }

        [HttpPost]
        [Route("inserir")]
        public Task<Instrumento> Inserir(Instrumento instrumento)
        {
            return null;
        }

        [HttpPut("alterar/{id}")]
        public Instrumento Alter(int id)
        {

            return null;
        }

        [HttpGet("delete/{id}")]
        public Instrumento Delete(int id)
        {
            return null;
        }
    }


}
