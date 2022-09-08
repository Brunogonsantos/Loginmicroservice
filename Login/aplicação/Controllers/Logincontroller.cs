using domain.domain.model;
using domain.Interface;
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

        private readonly ILoginLogic _locationLogic;
        private readonly ILogger<Logincontroller> _logger;

        public Logincontroller(ILogger<Logincontroller> logger, ILoginLogic loginLogic)
        {
            _logger = logger;
            _locationLogic = loginLogic;
        }
        [HttpPost("user")]
        public IActionResult AddUser([FromBody] UserModel request)
        {
            try
            {
                var result = _locationLogic.AddUser(request);
                return Ok(result);
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
                var result = _locationLogic.UserLogin (request);
                return Ok(result);
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
                var result = _locationLogic.UserAlterar(email);
                return Ok(result);
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
                var result = _locationLogic.UserExcluir(email);
                return Ok(result);

            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return StatusCode(500, "Contate o suporte");
            }

        }

    }
}
