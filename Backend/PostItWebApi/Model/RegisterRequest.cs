using System;
namespace PostItWebApi.Model
{
    public class RegisterRequest
    {
        public string Username { get; set; }
        public string Name { get; set; }
        public string InitialAddress { get; set; }
        public int InitialTeleNumber { get; set; }
    }
}
