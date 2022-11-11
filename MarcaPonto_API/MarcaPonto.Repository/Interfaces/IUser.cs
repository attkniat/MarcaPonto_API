using MarcaPonto.Enum;
using MarcaPonto.Model.Users;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MarcaPonto.Repository.Interfaces
{
    public  interface IUser
    {
        Task<bool> CreateUserAsync(UserCreateViewModel customer, UsersEnum role);
        CustomerViewModel GetCustomer(string customerId);
        Customer GetCustomerById(string customerIdGuild);
        Customer GetCustomerByEmailPassword(string customerEmail, string password);
        List<Customer> GetAllCustomers();
        Task<bool> UpdateUser(Customer customer);
        Task<bool> DeleteUser(string customerIdGuild);
    }
}
