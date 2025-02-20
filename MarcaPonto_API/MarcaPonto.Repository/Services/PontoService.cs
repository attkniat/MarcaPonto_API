using MarcaPonto.DataBase;
using MarcaPonto.Model.Ponto;
using MarcaPonto.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarcaPonto.Repository.Services
{
    public class PontoService : IPonto
    {
        public async Task<bool> MarcarPontoAsync(string userId)
        {
            using (var db = new AppDBContext())
            {
                var user = db.Customer.FirstOrDefault(c => c.Id == userId);

                var ponto = new Ponto
                {
                    Id = Guid.NewGuid().ToString(),
                    DataCadastro = Utils.Utils.DateTimeBr().ToString(),
                    UserId = userId,
                    UserName = user.Name,
                    Active = true
                };

                await db.Ponto.AddAsync(ponto);
                return await db.SaveChangesAsync() >= 1;
            }
        }

        public async Task<List<Ponto>> GetAllPontosAsync(string userId)
        {
            using (var db = new AppDBContext())
            {
                return await db.Ponto.Where(x => x.UserId == userId).ToListAsync();
            }
        }
        public async Task<bool> DeleteAllPontosByUserId(string userId)
        {
            using (var db = new AppDBContext())
            {
                foreach (var item in db.Ponto.Where(x => x.UserId == userId))
                {
                    db.Ponto.Remove(item);
                }

                return await db.SaveChangesAsync() >= 1;
            }
        }

        //public Task<Ponto> GetPontoByDateAsync(string userId)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<Ponto> GetPontoByUserIdAsync(string userId)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
