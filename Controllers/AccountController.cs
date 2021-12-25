using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using SecureShop.Models;
using SecureShopAPI.Data;
using SecureShopAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecureShopAPI.Controllers
{
    [Route("api")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IConfiguration _configuration;

        public AccountController(UserManager<ApplicationUser> userManager, RoleManager <IdentityRole> roleManager, IConfiguration configuration,  SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _configuration = configuration;
        }

        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> SignUp([FromBody]RegisterUser registerUser)
        {
            var userExist = await _userManager.FindByIdAsync(registerUser.email);
            if(userExist!= null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "User Already Exist" });
            }
            ApplicationUser user = new ApplicationUser()
            {

                fname = registerUser.fname,
                lname = registerUser.lname,
                company = registerUser.company,
                address = registerUser.address,
                city = registerUser.city,
                country = registerUser.country,
                postalcode = registerUser.postalcode,
                PhoneNumber = registerUser.phone,
                Email = registerUser.email,
                UserName = registerUser.email,
                SecurityStamp = Guid.NewGuid().ToString()

            };
            var result = await _userManager.CreateAsync(user, registerUser.password);
            if(!result.Succeeded)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "Registration failed" });

            }
            return Ok(new Response { Status = "Success", Message = "User Created" });
        }
    }
}
