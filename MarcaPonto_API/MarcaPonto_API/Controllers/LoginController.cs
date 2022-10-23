using MarcaPonto.Auth.Interfaces;
using MarcaPonto.Model.Usuários;
using MarcaPonto.Repository.Interfaces;
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
            var userFromDb = _user.GetCustomerByEmailPasswordRole(customer.Email, customer.Password, customer.Role);

            if (userFromDb == null)
                return NotFound(new { message = "User not Found" });

            var token = _token.GenerateToken(customer);

            customer.Password = string.Empty;

            return new
            {
                user = customer,
                token = token
            };
        }
    }
}
