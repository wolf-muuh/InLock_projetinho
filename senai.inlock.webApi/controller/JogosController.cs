using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using senai.inlock.webApi.domains;
using senai.inlock.webApi.Interfaces;
using senai.inlock.webApi.repositories;
using System.Data;

namespace senai.inlock.webApi.controller
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    [Authorize]
    public class JogosController : ControllerBase
    {


        private IJogosRepository _jogoRepository { get; set; }
        public JogosController()
        {
            _jogoRepository = new JogosRepository();
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                List<JogosDomain> lista = _jogoRepository.ListarTodos();

                return Ok(lista);
            }
            catch (Exception erro)
            {
                return BadRequest(erro.Message);
            }
        }

        [HttpPost]
        [Authorize(Roles = "Administrador")]
        public IActionResult Post(JogosDomain novoJogo)
        {
            try
            {
                _jogoRepository.Cadastrar(novoJogo);
                return Ok(novoJogo);
            }
            catch (Exception erro)
            {
                return BadRequest(erro.Message);
            }
        }

    }
}

