using MarcaPonto.DataBase;
using MarcaPonto.Enum;
using MarcaPonto.Model.Usuários;
using MarcaPonto.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarcaPonto.Repository.Services
{
    public class UserService : IUser
    {
        public async Task<bool> CreateUserAsync(Customer customer)
        {
            using (var db = new AppDBContext())
            {
                try
                {
                    customer.Id = Guid.NewGuid().ToString();
                    customer.Role = nameof(UsersEnum.Customer).ToString();

                    await db.Customer.AddAsync(customer);
                    return await db.SaveChangesAsync() >= 1;
                }
                catch (Exception ex)
                {
                    throw new Exception($"Was not possible to Create a new Customer ---> {ex.Message}");
                }
            }
        }

        public List<Customer> GetAllCustomers()
        {
            using (var db = new AppDBContext())
            {
                return db.Customer.ToList();
            }
        }

        public Customer GetCustomerByCPF(string customerCPF)
        {
            using (var db = new AppDBContext())
            {
                return db.Customer.FirstOrDefault(c => c.CPF == customerCPF);
            }
        }

        public Customer GetCustomerById(string customerIdGuild)
        {
            using (var db = new AppDBContext())
            {
                return db.Customer.FirstOrDefault(c => c.Id == customerIdGuild);
            }
        }

        public async Task<bool> UpdateUser(Customer customer)
        {
            using (var db = new AppDBContext())
            {
                try
                {
                    db.Customer.Update(customer);
                    return await db.SaveChangesAsync() >= 1;
                }
                catch (Exception ex)
                {
                    throw new Exception($"Was not possible to update the customer id {customer.Name} ---> {ex.Message}");
                }
            }
        }

        public async Task<bool> DeleteUser(string customerIdGuild)
        {
            using (var db = new AppDBContext())
            {
                try
                {
                    var contact = GetCustomerById(customerIdGuild);
                    db.Remove(contact);

                    return await db.SaveChangesAsync() >= 1;
                }
                catch (Exception ex)
                {
                    throw new Exception($"Was Not possible to delete the customer Id {customerIdGuild} ---> {ex.Message}");
                }
            }
        }
    }
}
