using MarcaPonto.Model.Usuários;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MarcaPonto.Repository.Interfaces
{
    public  interface IUser
    {
        Task<bool> CreateUserAsync(User customer);
        User GetCustomerById(string customerIdGuild);
        User GetCustomerByEmailPasswordRole(string customerEmail, string password, string Role);
        List<User> GetAllCustomers();
        Task<bool> UpdateUser(User customer);
        Task<bool> DeleteUser(string customerIdGuild);
    }
}
