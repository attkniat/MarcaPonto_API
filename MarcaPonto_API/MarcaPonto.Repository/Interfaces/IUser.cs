using MarcaPonto.Enum;
using MarcaPonto.Model.Usuários;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MarcaPonto.Repository.Interfaces
{
    public  interface IUser
    {
        Task<bool> CreateUserAsync(User customer, UsersEnum role);
        User GetCustomerById(string customerIdGuild);
        User GetCustomerByEmailPassword(string customerEmail, string password);
        List<User> GetAllCustomers();
        Task<bool> UpdateUser(User customer);
        Task<bool> DeleteUser(string customerIdGuild);
    }
}
