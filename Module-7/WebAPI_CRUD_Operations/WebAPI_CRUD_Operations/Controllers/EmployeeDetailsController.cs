using System.Collections.Generic;
using System.Web.Http;
using WebAPI_CRUD_Operations.Models;

namespace WebAPI_CRUD_Operations.Controllers
{
    public class EmployeeDetailsController : ApiController
    {
        //creating object of class employee
        BLEmployeeDetails objBLEmployee = new BLEmployeeDetails();

        //creating object of class employee
        Employee objEmployee = new Employee();

        //creating object of class Response
        Response objResponse = new Response();


        /// <summary>
        /// Getemployeedetails()
        /// Method returns list of types Employee
        /// which contains EmployeeId, EmployeeName, LastName, Designation, Salary, Experience
        /// </summary>
        /// <returns>returns list of type Employee</returns>
        [Route("")]
        [Route("api/GetAllEmployeeDetails")]
        [HttpGet]
        public IHttpActionResult GetAllEmployeeDetails()
        {
            objResponse = objBLEmployee.GetAllEmployees();
            List<Employee> lstEmployee = (List<Employee>)objResponse.Content;
            if (lstEmployee != null)
            {
                return Ok(lstEmployee);
            }
            else
            {
                return Ok(objResponse.Error_Message);
            }
        }

        /// <summary>
        /// GetemployeedetailsById(int id)
        /// match id given by user with EmployeeId in the database table
        /// if id found in the Employee table then it will return that Employee object
        /// where,id is taken form URI
        /// </summary>
        /// <param name="id">EmployeeId is unique id for each employee</param>
        /// <returns>return Employee object</returns>
        [Route("api/GetemployeedetailsById/{id}")]
        [HttpGet]
        public IHttpActionResult GetemployeedetailsById(int id)
        {
            objResponse = objBLEmployee.GetEmployeeById(id);
            objEmployee = (Employee)objResponse.Content;

            if (objEmployee != null)
            {
                return Ok(objEmployee);
            }
            else if (objResponse.Status != null)
            {
                return Ok(objResponse.Status);
            }
            else
            {
                return Ok(objResponse.Error_Message);
            }
        }

        /// <summary>
        /// InsertEmployeeDetails([FromBody] Employee values)
        /// method add new employee to Employee table
        /// where,where values of type Employee are taken from Body
        /// </summary>
        /// <param name="values">
        /// emp is object type of Employee 
        /// which contains EmployeeId,EmployeeName, LastName, Designation, Salary, Experience of Employee
        /// </param>
        /// <returns>boolean value true is operation succeed</returns>
        [Route("api/InsertEmployeeDetails")]
        [HttpPost]
        public IHttpActionResult InsertEmployeeDetails([FromBody] Employee values)
        {
            objResponse = objBLEmployee.Insert(values);

            if (objResponse.Status != null)
            {
                return Ok(objResponse.Status);
            }
            else
            {
                return Ok(objResponse.Error_Message);
            }
        }

        /// <summary>
        /// UpdateEmployeeDetails([FromUri]int id, [FromBody] Employee value)
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
        [Route("api/UpdateEmployeeDetails/{id}")]
        [HttpPut]
        public IHttpActionResult UpdateEmployeeDetails([FromUri] int id, [FromBody] Employee value)
        {
            value.EmployeeId = id;
            objResponse = objBLEmployee.Update(value);
            if (objResponse.Status != null)
            {
                return Ok(objResponse.Status);
            }
            else
            {
                return Ok(objResponse.Error_Message);
            }

        }

        /// <summary>
        /// DeleteEmployeedetails(int id)
        /// method remove particular employee from the list
        /// whose id matches to the id given by user
        /// where,id is taken from URI
        /// </summary>
        /// <param name="id">EmployeeId is unique id for each employee</param>
        [Route("api/DeleteEmployeedetails/{id}")]
        [HttpDelete]
        public IHttpActionResult DeleteEmployeedetails(int id)
        {
            objResponse = objBLEmployee.Delete(id);
            if (objResponse.Status != null)
            {
                return Ok(objResponse.Status);
            }
            else
            {
                return Ok(objResponse.Error_Message);
            }
        }
    }
}
