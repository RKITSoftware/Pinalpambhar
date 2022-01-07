using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using WebAPI_CRUD_Operations.Models;

namespace WebAPI_CRUD_Operations.Controllers
{
    public class BLEmployeeDetails : DatabaseConfig
    {
        #region private Members
        Response objResponse = new Response();

        //status variable is use to giv status of Database operation
        int status;
        #endregion Private Members

        #region Public Member Functions

        /// <summary>
        /// GetAllEmployees()
        /// Method returns list of types Employee
        /// which contains EmployeeId, EmployeeName, LastName, Designation, Salary, Experience
        /// </summary>
        /// <returns>returns list of type Employee</returns>
        public Response GetAllEmployees()
        {
            using (MySqlConnection objConnection = new MySqlConnection(connectionstring))
            {
                objConnection.Open();
                try
                {
                    MySqlCommand objcmd = new MySqlCommand("select EmployeeId,EmployeeName,LastName,Designation,Salary,experience from employeedetails", objConnection);

                    List<Employee> lstEmployee = new List<Employee>();
                    
                    using (MySqlDataReader objSDR = objcmd.ExecuteReader())
                    {
                        while (objSDR.Read())
                        {
                            lstEmployee.Add(new Employee
                            {
                                EmployeeId = (Convert.ToInt32(objSDR["EmployeeId"])),
                                EmployeeName = (Convert.ToString(objSDR["EmployeeName"])),
                                LastName = (Convert.ToString(objSDR["LastName"])),
                                Designation = (Convert.ToString(objSDR["Designation"])),
                                Salary = (Convert.ToInt32(objSDR["Salary"])),
                                Experience = (Convert.ToInt32(objSDR["experience"]))
                            });
                        }
                        objResponse.Content = lstEmployee;
                    }
                    return objResponse;

                }
                catch (MySqlException sqlex)
                {
                    objResponse.Error_Message = sqlex.Message;
                    return objResponse;
                }
                catch (System.Exception ex)
                {
                    objResponse.Error_Message = ex.Message;
                    return objResponse;
                }
            }
        }

        /// <summary>
        /// GetEmployeeById(int id) method 
        /// match id given by user with EmployeeId in the database table
        /// if id found in the Employee table then it will return that Employee object
        /// </summary>
        /// <param name="Id">EmployeeId is unique id for each employee</param>
        /// <returns>return Employee object</returns>
        public Response GetEmployeeById(SqlInt32 EmployeeId)
        {
            using (MySqlConnection objConnection = new MySqlConnection(connectionstring))
            {
                //opening database connection
                objConnection.Open();
                try
                {
                    MySqlCommand objcmd = new MySqlCommand("select EmployeeId,EmployeeName,LastName,Designation,Salary,experience from employeedetails where EmployeeId =" + EmployeeId, objConnection);
                    Employee objEmployee = new Employee();

                    using (MySqlDataReader objSDR = objcmd.ExecuteReader())
                    {
                        if (objSDR.HasRows)
                        {
                            while (objSDR.Read())
                            {
                                objEmployee.EmployeeId = Convert.ToInt32(objSDR["EmployeeId"]);
                                objEmployee.EmployeeName = Convert.ToString(objSDR["EmployeeName"]);
                                objEmployee.LastName = Convert.ToString(objSDR["LastName"]);
                                objEmployee.Designation = Convert.ToString(objSDR["Designation"]);
                                objEmployee.Salary = Convert.ToInt32(objSDR["Salary"]);
                                objEmployee.Experience = Convert.ToInt32(objSDR["experience"]);
                            }

                            objResponse.Content = objEmployee;
                            return objResponse;
                        }
                        else
                        {
                            objResponse.Status = "Data not found";
                            return objResponse;
                        }
                    }
                }
                catch (MySqlException sqlex)
                {
                    objResponse.Error_Message = sqlex.Message;
                    return objResponse;
                }
                catch (Exception ex)
                {
                    objResponse.Error_Message = ex.Message;
                    return objResponse;
                }
            }
        }

        /// <summary>
        /// Insert(Employee emp)
        /// method add new employee to Employee table
        /// </summary>
        /// <param name="employee">
        /// emp is object type of Employee 
        /// which contains EmployeeId,EmployeeName, LastName, Designation, Salary, Experience of Employee
        /// </param>
        /// <returns>boolean value true is operation succeed</returns>
        public Response Insert(Employee employee)
        {
            using (MySqlConnection objConnection = new MySqlConnection(connectionstring))
            {
                objConnection.Open();
                try
                {
                    MySqlCommand objcmd = new MySqlCommand("insert into EmployeeDetails (EmployeeName,LastName,Designation,Salary,experience) values ('" + employee.EmployeeName + "','" + employee.LastName + "','" + employee.Designation + "','" + employee.Salary + "','" + employee.Experience + "') ", objConnection);
                    objcmd.ExecuteNonQuery();

                    objResponse.Status = "Employee details Inserted Successfully";
                    return objResponse;
                }
                catch (MySqlException sqlex)
                {
                    objResponse.Error_Message = sqlex.Message;
                    return objResponse;
                }
                catch (Exception ex)
                {
                    objResponse.Error_Message = ex.Message;
                    return objResponse;
                }
            }
        }

        /// <summary>
        /// Delete(Int32 EmployeeId)
        /// method remove particular employee from the list
        /// whose id matches to the id given by user
        /// </summary>
        /// <param name="EmployeeId">EmployeeId is unique id for each employee</param>
        public Response Delete(SqlInt32 EmployeeId)
        {
            using (MySqlConnection objConnection = new MySqlConnection(connectionstring))
            {
                objConnection.Open();
                try
                {
                    MySqlCommand objcmd = new MySqlCommand("delete from employeedetails where EmployeeId = " + EmployeeId, objConnection);
                    status = objcmd.ExecuteNonQuery();

                    if (status > 0)
                    {
                        objResponse.Status = "Employee details deleted successfully";
                        return objResponse;
                    }
                    else
                    {
                        objResponse.Status = "Something went wrong";
                        return objResponse;
                    }

                }
                catch (MySqlException sqlex)
                {
                    objResponse.Error_Message = sqlex.Message;
                    return objResponse;
                }
                catch (System.Exception ex)
                {
                    objResponse.Error_Message = ex.Message;
                    return objResponse;
                }
            }
        }

        /// <summary>
        /// Update(Employee emp)
        ///  method edit EmployeeName Employee based on it's Id
        /// </summary>
        /// <param name="employee">
        /// emp is object type of Employee 
        /// which contains EmployeeId,EmployeeName, LastName, Designation, Salary, Experience of Employee
        /// </param>
        /// <returns>boolean value true is operation succeed</returns>
        public Response Update(Employee employee)
        {
            using (MySqlConnection objConnection = new MySqlConnection(connectionstring))
            {
                objConnection.Open();
                try
                {
                    MySqlCommand objcmd = new MySqlCommand("update EmployeeDetails set EmployeeName = '" + employee.EmployeeName + "',LastName = '" + employee.LastName + "', Designation = '" + employee.Designation + "', Salary = '" + employee.Salary + "', experience = '" + employee.Experience + "' where EmployeeId = '" + employee.EmployeeId + "';", objConnection);
                    status = objcmd.ExecuteNonQuery();

                    if (status > 0)
                    {
                        objResponse.Status = "Employee details Updated Successfully";
                        return objResponse;
                    }
                    else
                    {
                        objResponse.Status = "Something went wrong";
                        return objResponse;
                    }
                }
                catch (MySqlException sqlex)
                {
                    objResponse.Error_Message = sqlex.Message;
                    return objResponse;
                }
                catch (Exception ex)
                {
                    objResponse.Error_Message = ex.Message;
                    return objResponse;
                }
            }
        }
    }
    #endregion Public Member Functions

}
