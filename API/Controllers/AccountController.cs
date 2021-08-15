using API.Data;
using API.Dtos;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace API.Controllers
{
    public class AccountController : BaseApiController
    {
        private readonly DataContext _dataContext;

        public AccountController(DataContext context)
        {
            _dataContext = context;
        }

        [HttpPost("register")]
        public async Task<ActionResult<AppUser>> RegisterUser(RegisterUserDto registerUserDto)
        {
            using var hmac = new HMACSHA512();

            var user = new AppUser
            {
                UserName = registerUserDto.Username,
                PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(registerUserDto.Password)),
                PasswordSalt = hmac.Key
            };

            _dataContext.Users.Add(user);
            await _dataContext.SaveChangesAsync();

            return user;
        }
    }
}
