using MarcaPonto.Model.Usuários;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MarcaPonto.Repository.Interfaces
{
    public  interface IUser
    {
        Task<bool> CreateUserAsync(Customer customer);
        Customer GetCustomerById(string customerIdGuild);
        Customer GetCustomerByEmailPassword(string customerCPF);
        List<Customer> GetAllCustomers();
        Task<bool> UpdateUser(Customer customer);
        Task<bool> DeleteUser(string customerIdGuild);
    }
}
