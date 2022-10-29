using MarcaPonto.Model.Ponto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MarcaPonto.Repository.Interfaces
{
    public interface IPonto
    {
        Task<bool> MarcarPontoAsync(string userId);
        Task<List<Ponto>> GetAllPontosAsync(string userId);
        Task<Ponto> GetPontoByUserIdAsync(string userId);
        Task<Ponto> GetPontoByDateAsync(string userId);
    }
}