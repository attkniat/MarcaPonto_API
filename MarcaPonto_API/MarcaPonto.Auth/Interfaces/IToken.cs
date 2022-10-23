using MarcaPonto.Model.Usuários;

namespace MarcaPonto.Auth.Interfaces
{
    public interface IToken
    {
        string GenerateToken(UserViewModel customer);
    }
}
