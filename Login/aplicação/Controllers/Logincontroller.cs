using domain.domain.model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Login.Controllers
{
    [ApiController]
    [Route("v1.0/[controller]")]
    public class Logincontroller : ControllerBase
    {


        private readonly ILogger<Logincontroller> _logger;

        public Logincontroller(ILogger<Logincontroller> logger)
        {
            _logger = logger;
        }
        [HttpPost("user")]
        public IActionResult AddUser([FromBody] UserModel request)
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return StatusCode(500, "Contate o suporte");
            }
        }

        [HttpPost("login")]
        public IActionResult UserLogin([FromBody] UserLoginModel request)
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return StatusCode(500, "Contate o suporte");
            }

        }
        [HttpPatch("alterar")]
        public IActionResult UserAlterar([FromQuery] string email)
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return StatusCode(500, "Contate o suporte");
            }

        }
        [HttpDelete("Excluir")]
        public IActionResult UserExcluir([FromQuery] string email)
        {
            try
            {
                return Ok();

            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return StatusCode(500, "Contate o suporte");
            }

        }

    }
}
