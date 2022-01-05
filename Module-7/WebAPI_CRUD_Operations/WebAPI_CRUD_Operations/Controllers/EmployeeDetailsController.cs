using System.Collections.Generic;
using System.Web.Http;
using WebAPI_CRUD_Operations.Models;

namespace WebAPI_CRUD_Operations.Controllers
{
    public class EmployeeDetailsController : ApiController
    {
        //creating object of class employee
        BLEmployeeDetails lstEmployee = new BLEmployeeDetails();


        /// <summary>
        /// Get()
        /// Method returns list of types Employee
        /// which contains EmployeeId, EmployeeName, LastName, Designation, Salary, Experience
        /// </summary>
        /// <returns>returns list of type Employee</returns>
        [Route("")]
        [Route("Default")]
        [Route("api/employeedetails")]
        [HttpGet]
        public List<Employee> Get()
        {
            List<Employee> Employee = lstEmployee.GetAllEmployees();
            return Employee;
        }

        /// <summary>
        /// Get(int id)
        /// match id given by user with EmployeeId in the database table
        /// if id found in the Employee table then it will return that Employee object
        /// where,id is taken form URI
        /// </summary>
        /// <param name="id">EmployeeId is unique id for each employee</param>
        /// <returns>return Employee object</returns>
        [Route("api/employeedetails/{id}")]
        [HttpGet]
        public Employee Get(int id)
        {
            Employee objemp = new Employee();
            objemp = lstEmployee.GetEmployeeById(id);
            return objemp;
        }

        /// <summary>
        /// Post([FromBody] Employee values)
        /// method add new employee to Employee table
        /// where,where values of type Employee are taken from Body
        /// </summary>
        /// <param name="values">
        /// emp is object type of Employee 
        /// which contains EmployeeId,EmployeeName, LastName, Designation, Salary, Experience of Employee
        /// </param>
        /// <returns>boolean value true is operation succeed</returns>
        [Route("api/employeedetails")]
        [HttpPost]
        public bool Post([FromBody] Employee values)
        {
            values.EmployeeId = 0;
            bool status = lstEmployee.Insert(values);
            return status;
        }

        /// <summary>
        /// Put([FromUri]int id, [FromBody] Employee value)
        /// method edit EmployeeName Employee based on it's Id
        /// where,id is taken from URI 
        /// other information of employee is taken from Body
        /// </summary>
        /// <param name="id">EmployeeId is unique id for each employee</param>
        /// <param name="value">
        /// emp is object type of Employee 
        /// which contains EmployeeId,EmployeeName, LastName, Designation, Salary, Experience of Employee
        /// </param>
        /// <returns></returns>
        [Route("api/employeedetails/{id}")]
        [HttpPut]
        public void Put([FromUri] int id, [FromBody] Employee value)
        {
            value.EmployeeId = id;
            lstEmployee.Update(value);

        }

        /// <summary>
        /// Delete(int id)
        /// method remove particular employee from the list
        /// whose id matches to the id given by user
        /// where,id is taken from URI
        /// </summary>
        /// <param name="id">EmployeeId is unique id for each employee</param>
        [Route("api/employeedetails/{id}")]
        [HttpDelete]
        public void Delete(int id)
        {
            lstEmployee.Delete(id);
        }
    }
}
