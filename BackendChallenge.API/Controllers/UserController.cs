using BackendChallenge.API.Models;
using BackendChallenge.API.Services;
using Microsoft.AspNetCore.Mvc;
using System;

namespace BackendChallenge.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IPasswordService _passwordService;
        
        public UserController(IPasswordService passwordService)
        {
            _passwordService = passwordService;
        }

        [HttpPost]
        public IActionResult IsValidPassword([FromBody] UserInputModel user)
        {
            try
            {
                bool result = _passwordService.IsValidPassword(user.Password); 
                return result ? Ok() : BadRequest("Senha inválida");
            }
            catch(Exception ex)
            { 
                return StatusCode(500, ex);
            }
        }
    }
}
