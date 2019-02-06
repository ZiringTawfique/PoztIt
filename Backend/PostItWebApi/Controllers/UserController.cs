using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Application.UseCases.UserUseCase;
using Domain.Model;
using Microsoft.AspNetCore.Mvc;
using PostItWebApi.Model;

namespace PostItWebApi.Controllers
{
    public class UserController : Controller
    {
        IUserCRUD _userCRUD;

        public UserController(IUserCRUD userCRUD)
        {
            _userCRUD = userCRUD;
        }

        [Route("User/GetAUser")]
        [HttpGet("{username}")]
        public Task<User> Get(string username) => _userCRUD.GetUser(username);


        [Route("User/Post")]
        [HttpPut]
        public void Put([FromBody]UserRequest request)
        {
            _userCRUD.Register(request.Username, request.Name, request.InitialAddress,
            request.InitialTeleNumber);
        }

        [Route("User/Update")]
        [HttpPut]
        public void Update([FromBody]UserRequest request)
        {
            _userCRUD.UpdateUser(request.Username, request.Name, request.InitialAddress,
            request.InitialTeleNumber);
        }

        [Route("User/Delete")]
        [HttpDelete("{username}")]
        public void Delete(string username) => _userCRUD.DeleteUser(username);
    }
}
