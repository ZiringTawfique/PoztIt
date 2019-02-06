using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Application.UseCases.Register;
using Domain.Model;
using Microsoft.AspNetCore.Mvc;
using PostItWebApi.Model;

namespace PostItWebApi.Controllers
{
    public class UserController : Controller
    {
        IRegisterUser _register;

        public UserController(IRegisterUser register)
        {
            _register = register;
        }

        [Route("User/GetAUser")]
        [HttpGet("{username}")]
        public Task<User> Get(string username) => _register.GetUser(username);


        [Route("User/Post")]
        [HttpPut]
        public void Put([FromBody]UserRequest request)
        {
            _register.Register(request.Username, request.Name, request.InitialAddress,
            request.InitialTeleNumber);
        }

        [Route("User/Update")]
        [HttpPut]
        public void Update([FromBody]UserRequest request)
        {
            _register.UpdateUser(request.Username, request.Name, request.InitialAddress,
            request.InitialTeleNumber);
        }

        [Route("User/Delete")]
        [HttpDelete("{username}")]
        public void Delete(string username) => _register.DeleteUser(username);
    }
}
