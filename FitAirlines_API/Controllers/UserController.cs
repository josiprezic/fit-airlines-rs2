using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FitAirlines_API.Controllers
{
    public class User 
    {
        public String name;
        public int age;

        public User(String name, int age) 
        {
            this.name = name;
            this.age = age;
        }
    }
    public class UserController : ApiController
    {
        [HttpGet]
        // [Route("")]
        public List<User> GetUsers() 
        {
            User user1 = new User("Josip", 23);
            User user2 = new User("Natalia", 21);
            User user3 = new User("Ola", 22);


            List<User> list = new List<User>();
            list.Add(user1);
            list.Add(user2);
            list.Add(user3);
            return list;
        }
    }
}
