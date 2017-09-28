using LoginContrucks.Helpers;
using LoginContrucks.Services;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Text;
using System.Web.Http;

namespace LoginContrucks.Controllers
{
    

        [Authorize]
        [Route("[controller]")]
        public class UserController : ApiController
        {
            private IUserService _userService;
            private IMapper _mapper;
            private readonly AppSettings _appSettings;

            public UsersController(
                IUserService userService,
                IMapper mapper,
                IOptions<AppSettings> appSettings)
            {
                _userService = userService;
                _mapper = mapper;
                _appSettings = appSettings.Value;
            }

            [AllowAnonymous]
            [HttpPost("authenticate")]
            public IActionResult Authenticate([FromBody]UserDto userDto)
            {
                var user = _userService.Authenticate(userDto.Username, userDto.Password);

                if (user == null)
                    return Unauthorized();

                var tokenHandler = new JwtSecurityTokenHandler();
                var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new Claim[]
                    {
                    new Claim(ClaimTypes.Name, user.Id.ToString())
                    }),
                    Expires = DateTime.UtcNow.AddDays(7),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
                };
                var token = tokenHandler.CreateToken(tokenDescriptor);
                var tokenString = tokenHandler.WriteToken(token);

                // return basic user info (without password) and token to store client side
                return Ok(new
                {
                    Id = user.Id,
                    Username = user.Username,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Token = tokenString
                });
            }

        }
    }
