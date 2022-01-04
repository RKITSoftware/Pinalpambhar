using System.Collections.Generic;
using System.Web.Http;
using WebAPI_CRUD_Operations.Models;

namespace WebAPI_CRUD_Operations.Controllers
{
    public class EmployeeDetailsController : ApiController
    {
        EmployeeDetails lstEmployee = new EmployeeDetails();
        // GET: api/EmployeeDetails
        public List<Employee> Get()
        {
            List<Employee> Employee = lstEmployee.GetAllEmployees();
            return Employee;
        }

        // GET: api/EmployeeDetails/5
        public Employee Get(int id)
        {
            Employee objemp = new Employee();
            objemp = lstEmployee.GetEmployeeById(id);
            return objemp;
        }

        // POST: api/EmployeeDetails
        public bool Post([FromBody] Employee values)
        {
            values.EmployeeId = 0;
            bool status = lstEmployee.Insert(values);
            return status;
        }

        // PUT: api/EmployeeDetails/5
        public bool Put([FromUri]int id, [FromBody] Employee value)
        {
            value.EmployeeId = id;
            bool status = lstEmployee.Update(value);
            return status;
        }

        // DELETE: api/EmployeeDetails/5
        public void Delete(int id)
        {
            lstEmployee.Delete(id);
        }
    }
}
