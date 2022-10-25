using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using MarcaPonto.Repository.Services;
using MarcaPonto.Repository.Interfaces;

namespace MarcaPonto_API.Controllers
{
    [ApiController]
    public class PontoController : Controller
    {
        public readonly IPonto _ponto;

        public PontoController(IPonto ponto) { _ponto = ponto; }

        [HttpPost]
        [Route("marcar-ponto-async")]
        [Authorize(Roles = "Customer,Administrador")]
        public async Task MarcarPontoAsync()
        {
            try
            {
                var identity = HttpContext.User.Identity as ClaimsIdentity;
                var userId = identity.Claims.First(c => c.Type == "userId").Value;

                await _ponto.MarcarPontoAsync(userId);

            }
            catch (Exception ex)
            {
                throw new Exception($"Was not possible to procede in {nameof(MarcarPontoAsync)} ---> {ex.Message}");
            }
        }
    }
}