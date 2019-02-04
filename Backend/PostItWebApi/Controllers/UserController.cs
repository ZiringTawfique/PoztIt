using System;
using System.Collections.Generic;
using Application.UseCases.Register;
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

        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        [Route("User/Post")]
        [HttpPost]
        public void Post([FromBody]RegisterRequest request)
        {
            _register.Register(request.Username, request.Name, request.InitialAddress,
            request.InitialTeleNumber);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
