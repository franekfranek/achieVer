using System.Threading.Tasks;
using API.DTOs;
using API.Interfaces;
using API.Models;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class AccountController : BaseApiController
    {
        private readonly IMapper _mapper;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _singnInManager;
        private readonly ITokenService _tokenService;

        public AccountController(IMapper mapper, UserManager<AppUser> userManager,
                                     SignInManager<AppUser> singnInManager, ITokenService tokenService)
        {
            _tokenService = tokenService;
            _mapper = mapper;
            _userManager = userManager;
            _singnInManager = singnInManager;
        }


        [HttpPost("register")]
        public async Task<IActionResult> Register(UserForRegisterDto userForRegisterDto) //[FromBody] can be used here but its not necesarry cuase of[ApiController]
        {

            var userToCreate = _mapper.Map<AppUser>(userForRegisterDto);
            userToCreate.UserName = userForRegisterDto.UserName.ToLower();

            var result = await _userManager.CreateAsync(userToCreate, userForRegisterDto.Password);

            userToCreate.Token = _tokenService.CreateToken(userToCreate);

            if (result.Succeeded)
            {
                return Ok(userToCreate);
            }

            return BadRequest(result.Errors);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(UserForLoginDto userForLoginDto)
        {
            var userReturn = await _userManager.FindByNameAsync(userForLoginDto.UserName);

            var result = await _singnInManager
                                    .CheckPasswordSignInAsync(userReturn, userForLoginDto.Password, false);

            userReturn.Token = _tokenService.CreateToken(userReturn);

            if (result.Succeeded)
            {
                return Ok(new
                {
                    user = userReturn
                });
            }

            return Unauthorized();
        }

    }
}