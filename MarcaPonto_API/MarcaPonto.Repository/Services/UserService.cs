﻿using MarcaPonto.DataBase;
using MarcaPonto.Enum;
using MarcaPonto.Model.Users;
using MarcaPonto.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarcaPonto.Repository.Services
{
    public class UserService : IUser
    {
        public async Task<bool> CreateUserAsync(UserCreateViewModel customerCreate, UsersEnum role)
        {
            using (var db = new AppDBContext())
            {
                try
                {
                    var customer = new Customer()
                    {
                        Id = Guid.NewGuid().ToString(),
                        Role = role.ToString(),
                        CPF = customerCreate.CPF,
                        Email = customerCreate.Email,
                        Name = customerCreate.Name,
                        Password = customerCreate.Password
                    };

                    await db.Customer.AddAsync(customer);
                    return await db.SaveChangesAsync() >= 1;
                }
                catch (Exception ex)
                {
                    throw new Exception($"Was not possible to Create a new {role} ---> {ex.Message}");
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

        public Customer GetCustomerByEmailPassword(string customerEmail, string password)
        {
            using (var db = new AppDBContext())
            {
                return db.Customer.FirstOrDefault(c => c.Email == customerEmail && c.Password == password);
            }
        }

        public CustomerViewModel GetCustomer(string customerIdGuild)
        {
            using (var db = new AppDBContext())
            {
                var customer = db.Customer.FirstOrDefault(c => c.Id == customerIdGuild);

                return new CustomerViewModel
                {
                    Id = customer.Id,
                    Name = customer.Name,
                    CPF = customer.CPF,
                    Email = customer.Email,
                    Role = customer.Role
                };
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
