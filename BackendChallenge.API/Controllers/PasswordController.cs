using BackendChallenge.API.Models.InputModels;
using BackendChallenge.API.Services;
using Microsoft.AspNetCore.Mvc;
using System;

namespace BackendChallenge.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PasswordController : ControllerBase
    {
        private readonly IPasswordService _passwordService;

        public PasswordController(IPasswordService passwordService)
        {
            _passwordService = passwordService;
        }

        [HttpPost("validate")]
        public IActionResult ValidatePassword([FromBody] PasswordInputModel user)
        {
            try
            {
                bool isPasswordValid = _passwordService.IsValidPassword(user.Password); 
                return isPasswordValid ? Ok(isPasswordValid) : BadRequest(isPasswordValid);
            }
            catch(Exception ex)
            { 
                return StatusCode(500, ex);
            }
        }
    }
}
