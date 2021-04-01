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
    [EnableCors("*","*","*")]
    public class EmployeeController : ApiController
    {
        public List<Employee> GetEmployees()
        {
            var employees = new List<Employee>
            {
                new Employee{Id=1, Name="Test1", Location="Mars", Salary=10090000},
                new Employee{Id=2, Name="Test2", Location="Mars", Salary=10000000},
                new Employee{Id=3, Name="Test3", Location="Mars", Salary=10007000},
                new Employee{Id=4, Name="Test4", Location="Mars", Salary=10050000},
                new Employee{Id=5, Name="Test5", Location="Mars", Salary=1065400},
                new Employee{Id=6, Name="Test6", Location="Mars", Salary=1003200}
            };
            return employees;
        }
    }
}
