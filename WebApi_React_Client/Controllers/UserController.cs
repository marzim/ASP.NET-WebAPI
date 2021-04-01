using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using WebApi_React_Client.Models;

namespace WebApi_React_Client.Controllers
{
    [EnableCors("*", "*", "*")]
    public class UserController : ApiController
    {
        public List<User> GetUsers()
        {
            var users = new List<User>
            {
                new User{Id=1, UserName="testing1", Password="lasjdf"},
                new User{Id=4, UserName="testing1", Password="lasjdf"},
                new User{Id=3, UserName="testing1", Password="lasjdf"},
                new User{Id=7, UserName="testing1", Password="lasjdf"}
            };
            return users;
        }

    }
}
