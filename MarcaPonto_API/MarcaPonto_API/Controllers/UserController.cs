using MarcaPonto.Model.Usuários;
using MarcaPonto.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MarcaPonto_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {
        public readonly IUser _userResitory;

        public UserController(IUser userResitory)
        {
            _userResitory = userResitory;
        }

        [HttpPost]
        [Route("create-customer")]
        public void CreateUser(User customer)
        {
            try
            {
                _userResitory.CreateUserAsync(customer);
            }
            catch (Exception ex)
            {
                throw new Exception($"Was not possible to invoke the Customer Services ---> {ex.Message}");
            }
        }

        [HttpGet]
        [Route("get-all-customers")]
        public List<User> GetAllCustomers()
        {
            try
            {
                return _userResitory.GetAllCustomers();
            }
            catch (Exception ex)
            {
                throw new Exception($"Was not possible to Get all the Customers ---> {ex.Message}");
            }
        }

        [HttpGet]
        [Route("get-customer-by-id")]
        public User GetCustomerById (string customerId)
        {
            try
            {
                return _userResitory.GetCustomerById(customerId);
            }
            catch (Exception ex)
            {
                throw new Exception($"Was not possible to Get the Customer by id = {customerId} ---> {ex.Message}");
            }
        }

        [HttpPut]
        [Route("update-customer")]
        public async Task<bool> UpdateUserAsync(User customer)
        {
            try
            {
                return await _userResitory.UpdateUser(customer);
            }
            catch (Exception ex)
            {
                throw new Exception($"Was not possible to Update the Customer {customer.Name} ---> {ex.Message}");
            }
        }

        [HttpDelete]
        [Route("delete-customer")]
        public async Task<bool> DeleteUser(string customerId)
        {
            try
            {
                return await _userResitory.DeleteUser(customerId);
            }
            catch (Exception ex)
            {
                throw new Exception($"Was not possible to Delete the Customer {customerId} ---> {ex.Message}");
            }
        }
    }
}
