using System.Collections.Generic;
using System.Web.Http;

namespace AuthorizationDemos.Controllers
{
    [Authorize]
    public class EmployeeController : ApiController
    {
        [HttpGet]
        [Route("api/EmployeeAPI")]
        public List<Employee> Get()
        {
            return new List<Employee>()
            {
                new Employee {
                    EmpNo = 1,
                    EmpName = "Garrett",
                    Salary = 50000,
                    DeptName = "Hello"
                }
            };
        }
    }

    public class Employee
    {
        public int EmpNo { get; set; }
        public string EmpName { get; set; }
        public decimal Salary { get; set; }
        public string DeptName { get; set; }
    }
}
