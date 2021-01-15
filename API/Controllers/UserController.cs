using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Interfaces;
using API.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    public class UserController : BaseApiController
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _singnInManager;
        private readonly DataContext _data;

        public UserController(ITaskTodoRepository repository, UserManager<AppUser> userManager,
                                                         SignInManager<AppUser> singnInManager,
                                                         DataContext data)
        {
            _data = data;
            _singnInManager = singnInManager;
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<List<AppUser>> GetUsers()
        {
            return await _data.Users.OrderByDescending(user => user.UserName).ToListAsync();
        }
    }
}