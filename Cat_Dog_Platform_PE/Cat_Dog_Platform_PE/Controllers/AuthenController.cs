﻿using Cat_Dog_Platform_PE.DTO;
using Cat_Dog_Platform_PE.DTO.requestDTO;
using Cat_Dog_Platform_PE.Entity;
using Cat_Dog_Platform_PE.Helper;
using Cat_Dog_Platform_PE.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cat_Dog_Platform_PE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenController : ControllerBase
    {
        private readonly AccountService accountService;
        private readonly Util util;
        public AuthenController(AccountService accountService, Util util)
        {
            this.accountService = accountService;
            this.util = util;
        }

        [HttpPost("SignIn")]
        public async Task<IActionResult> SignIn(SignInDTO dto)
        {
            try
            {
                var result = await accountService.SignIn(dto.Email, dto.Password);

                if (result == null)
                {
                    return Ok("Unauthenticated"); ;
                }
                return Ok(result);
            }
            catch (Exception ex)
            {
                return Ok(ex);
            }
        }

        [HttpPost("SignUp")]
        public async Task<IActionResult> SignUp(SignUpDTO account)
        {
            try
            {
                account.HashPassword = util.hashPassword(account.HashPassword);
                await accountService.SignUp(account);
                return StatusCode(StatusCodes.Status201Created);
            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }
            
        }
    }
}
