<<<<<<< HEAD
﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using senai.inlock.webApi.domains;
using senai.inlock.webApi.Interfaces;
using senai.inlock.webApi.repositories;
using System.Data;
=======
﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
>>>>>>> c4c1c008ddbce2e4c940a5b723e572183a68b90c

namespace senai.inlock.webApi.controller
{
    [Route("api/[controller]")]
    [ApiController]
<<<<<<< HEAD
    [Produces("application/json")]
    [Authorize]
    public class EstudioController : ControllerBase
    {
        private IEstudioRepository _estudioRepository { get; set; }

        public EstudioController()
        {
            _estudioRepository = new EstudioRepository();
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                List<EstudioDomain> lista = _estudioRepository.ListarTodos();
                return Ok(lista);
            }
            catch (Exception erro)
            {
                return BadRequest(erro.Message);
            }
        }

        [HttpPost]
        [Authorize(Roles = "Administrador")]
        public IActionResult Post(EstudioDomain estudio)
        {
            try
            {
                _estudioRepository.Cadastrar(estudio);
                return Ok(estudio);
            }
            catch (Exception erro)
            {
                return BadRequest(erro.Message);
            }
        }
=======
    public class EstudioController : ControllerBase
    {
>>>>>>> c4c1c008ddbce2e4c940a5b723e572183a68b90c
    }
}
