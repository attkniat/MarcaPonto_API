using MarcaPonto.Model.Usuários;
using MarcaPonto.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarcaPonto.Repository.Services
{
    internal class UserService : IUser
    {
        public Task<bool> CreateUser(Customer customer)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteUser(string customerIdGuild, string CPF)
        {
            throw new NotImplementedException();
        }

        public Task<List<Customer>> GetAllCustomers()
        {
            throw new NotImplementedException();
        }

        public Task<Customer> GetCustomerByCPF(string customerCPF)
        {
            throw new NotImplementedException();
        }

        public Task<Customer> GetCustomerById(string customerIdGuild)
        {
            throw new NotImplementedException();
        }

        public Task<Customer> UpdateUser(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
