using MarcaPonto.Enum;
using MarcaPonto.Model.Usuários;
using MarcaPonto.Repository.Interfaces;
using Microsoft.AspNetCore.Authorization;
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

        [HttpGet]
        [Route("welcome")]
        [AllowAnonymous]
        public string Welcome() => "Welcome to MarcaPonto API!";

        [HttpPost]
        [Route("create-customer")]
        [Authorize(Roles = "Administrador")]
        public void CreateUser(User customer)
        {
            try
            {
                _userResitory.CreateUserAsync(customer, UsersEnum.Customer);
            }
            catch (Exception ex)
            {
                throw new Exception($"Was not possible to invoke the Create Customer Services ---> {ex.Message}");
            }
        }

        [HttpPost]
        [Route("create-admin")]
        //[Authorize(Roles = "Administrador")]
        [AllowAnonymous]
        public void CreateAdmin(User customer)
        {
            try
            {
                _userResitory.CreateUserAsync(customer, UsersEnum.Administrador);
            }
            catch (Exception ex)
            {
                throw new Exception($"Was not possible to invoke the Create Admin Services ---> {ex.Message}");
            }
        }

        [HttpGet]
        [Route("get-all-customers")]
        [Authorize(Roles = "Customer,Administrador")]
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
        [Authorize(Roles = "Administrador")]
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
        [Authorize(Roles = "Customer,Administrador")]
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
        [Authorize(Roles = "Administrador")]
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
