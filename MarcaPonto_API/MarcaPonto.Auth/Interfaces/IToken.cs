using MarcaPonto.Model.Users;
using System.Threading.Tasks;

namespace MarcaPonto.Auth.Interfaces
{
    public interface IToken
    {
        Task<string> GenerateToken(UserAuthModel customer);
    }
}
