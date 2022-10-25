using MarcaPonto.Model.Ponto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MarcaPonto.Repository.Interfaces
{
    public interface IPonto
    {
        Task<bool> MarcarPontoAsync(string userName);
        Task<List<Ponto>> GetAllPontosAsync();
        Task<Ponto> GetPontoByUserIdAsync(string userId);
        Task<Ponto> GetPontoByDateAsync(string userId);
    }
}