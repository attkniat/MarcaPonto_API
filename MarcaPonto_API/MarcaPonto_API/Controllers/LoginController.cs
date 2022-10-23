using MarcaPonto.Auth.Interfaces;
using MarcaPonto.Model.Users;
using MarcaPonto.Model.Usuários;
using MarcaPonto.Repository.Interfaces;
using MarcaPonto.Enum;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace MarcaPonto_API.Controllers
{
    [ApiController]
    public class LoginController : ControllerBase
    {
        public readonly IToken _token;
        public readonly IUser _user;

        public LoginController(IToken token, IUser user)
        {
            _token = token;
            _user = user;
        }

        [HttpPost]
        [Route("login")]
        public async Task<ActionResult<dynamic>> Authenticate([FromBody] UserViewModel customer)
        {
            var userFromDb = _user.GetCustomerByEmailPassword(customer.Email, customer.Password);

            if (userFromDb == null)
                return NotFound(new { message = "User not Found" });

            var userAuth = new UserAuthModel()
            {
                Email = userFromDb.Email,
                Password = userFromDb.Password,
                Role = nameof(UsersEnum.Customer)
            };

            var token = await _token.GenerateToken(userAuth);

            customer.Password = string.Empty;

            return new
            {
                user = customer,
                token = token
            };
        }

        [HttpPost]
        [Route("admin-login")]
        public async Task<ActionResult<dynamic>> AdminAuthenticate([FromBody] UserViewModel customer)
        {
            var userFromDb = _user.GetCustomerByEmailPassword(customer.Email, customer.Password);

            if (userFromDb == null)
                return NotFound(new { message = "User not Found" });

            var userAuth = new UserAuthModel()
            {
                Email = userFromDb.Email,
                Password = userFromDb.Password,
                Role = nameof(UsersEnum.Administrador)
            };

            var token = await _token.GenerateToken(userAuth);

            customer.Password = string.Empty;

            return new
            {
                user = customer,
                token = token
            };
        }
    }
}
