using Microsoft.AspNetCore.Mvc;
using webapi.inlock.tarde.Domains;
using webapi.inlock.tarde.Interfaces;
using webapi.inlock.tarde.Repositories;

namespace webapi.inlock.tarde.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class EstudioController : ControllerBase
    {
        private IEstudioRepository _estudioRepository { get; set; }
        public EstudioController() 
        { 
            _estudioRepository = new EstudioRepository();
        }

        /// <summary>
        /// EndPoint que lista todos os Estúdios
        /// </summary>
        /// <returns>Uma lista de Estúdios</returns>
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_estudioRepository.Listar());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        /// <summary>
        /// EndPoint que lista Estúdios com Jogos.
        /// </summary>
        /// <returns>Uma lista de Estúdios com seus respectivos Jogos</returns>
        [HttpGet("ListarComJogos")]
        public IActionResult GetGames() 
        {
            try
            {
                return Ok(_estudioRepository.ListarComJogos());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);              
            }
        }

        /// <summary>
        /// EndPoint que deleta um Estúdio
        /// </summary>
        /// <param name="ID">Parâmetro</param>
        /// <returns>Deleta um determinado Estúdio</returns>
        [HttpDelete("{ID}")]
        public IActionResult Delete(Guid ID)
        {
            try
            {
                _estudioRepository.Deletar(ID);
                return NoContent();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        /// <summary>
        /// EndPoint que cadastra um novo Estúdio
        /// </summary>
        /// <param name="novoEstudio">Objeto cadastrado</param>
        /// <returns>Um novo cadastro</returns>
        [HttpPost]
        public IActionResult Post(Estudio novoEstudio)
        {
            try
            {
                _estudioRepository.Cadastrar(novoEstudio);
                return StatusCode(201);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);        
            }
        }

        /// <summary>
        /// EndPoint que busca o Estúdio por ID
        /// </summary>
        /// <param name="ID">Parâmetro</param>
        /// <returns>O Estúdio equivalente ao ID</returns>
        [HttpGet("{ID}")]
        public IActionResult GetByID(Guid ID)
        {
            return Ok(_estudioRepository.BuscarPorId(ID));
        }

        /// <summary>
        /// EndPoint
        /// </summary>
        /// <param name="ID">Parâmetro</param>
        /// <param name="novoEstudio">Objeto atualizado</param>
        /// <returns>Atualização de um Estúdio</returns>
        [HttpPut("{ID}")]
        public IActionResult Update(Guid ID, Estudio novoEstudio)
        {
            _estudioRepository.Atualizar(ID, novoEstudio);
            return StatusCode(204);
        }
    }
}
