using MarcaPonto.Model.Usuários;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MarcaPonto.Repository.Interfaces
{
    public  interface IUser
    {
        Task<bool> CreateUser(Customer customer);
        Task<Customer> GetCustomerById(string customerIdGuild);
        Task<Customer> GetCustomerByCPF(string customerCPF);
        Task<List<Customer>> GetAllCustomers();
        Task<Customer> UpdateUser(Customer customer);
        Task<bool> DeleteUser(string customerIdGuild, string CPF);
    }
}
