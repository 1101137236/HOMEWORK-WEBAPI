using KuasCore.Models;
using KuasCore.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace MvcApplication1.Controllers
{
    public class EmployeeController : ApiController
    {
        public IEmployeeService EmployeeService { get; set; }

        [HttpGet]
        [ActionName("byName")]
        public Employee GetEmployeeByName(string name)

        {
            var employee = EmployeeService.GetEmployeeByName(name);

            if (employee == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            return employee;
        }




        //[HttpGet]
        //[ActionName("byName")]
        //public Employee GetEmployeeByName(string name)
        //{
        //    var employee = EmployeeService.GetEmployeeByName(name);

        //    if (employee == null)
        //    {
        //        throw new HttpResponseException(HttpStatusCode.NotFound);
        //    }

        //    return employee;
        //}
    }
}
