using ASP.Net_Core_Final_Project_Web_API.IServices;
using ASP.Net_Core_Final_Project_Web_API.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace ASP.Net_Core_Final_Project_Web_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        /// <summary>
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>

        [HttpGet("Login")]
        public IActionResult Login([FromQuery] LoginModel model)
        {
            var response = _userService.Login(model);

            if (response == null)
                return BadRequest(new { message = "Username or password is incorrect" });

            return Ok(response);
        }


    }
}
