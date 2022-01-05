using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlTypes;
using WebAPI_CRUD_Operations.Models;

namespace WebAPI_CRUD_Operations.Controllers
{
    public class BLEmployeeDetails
    {
        #region private Members
        //connectionstring is used to access databse connection
        string connectionstring = ConfigurationManager.ConnectionStrings["EmployeeConnectionString"].ConnectionString;

        //Message is variable used to store expecption occurs during access database
        string Message;
        #endregion Private Members

        #region Public Member Functions

        /// <summary>
        /// GetAllEmployees()
        /// Method returns list of types Employee
        /// which contains EmployeeId, EmployeeName, LastName, Designation, Salary, Experience
        /// </summary>
        /// <returns>returns list of type Employee</returns>
        public List<Employee> GetAllEmployees()
        {
            using (MySqlConnection objconn = new MySqlConnection(connectionstring))
            {
                //opening database connection
                objconn.Open();
                try
                {
                    MySqlCommand objcmd = new MySqlCommand("select * from employeedetails", objconn);

                    List<Employee> employee = new List<Employee>();
                    Employee emp = new Employee();
                    using (MySqlDataReader objSDR = objcmd.ExecuteReader())
                    {
                        while (objSDR.Read())
                        {
                            employee.Add(new Employee
                            {
                                EmployeeId = (Convert.ToInt32(objSDR["EmployeeId"])),
                                EmployeeName = (Convert.ToString(objSDR["EmployeeName"])),
                                LastName = (Convert.ToString(objSDR["LastName"])),
                                Designation = (Convert.ToString(objSDR["Designation"])),
                                Salary = (Convert.ToInt32(objSDR["Salary"])),
                                Experience = (Convert.ToInt32(objSDR["experience"]))
                            });
                        }
                    }
                    return employee;

                }
                catch (MySqlException sqlex)
                {
                    Message = sqlex.InnerException.Message;
                    return null;
                }
                catch (System.Exception ex)
                {
                    Message = ex.InnerException.Message;
                    return null;
                }
                finally
                {
                    if (objconn.State == ConnectionState.Open)
                        objconn.Close();
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
        public Employee GetEmployeeById(SqlInt32 EmployeeId)
        {
            using (MySqlConnection objConn = new MySqlConnection(connectionstring))
            {
                //opening database connection
                objConn.Open();
                try
                {
                    MySqlCommand objcmd = new MySqlCommand("select * from employeedetails where EmployeeId =" + EmployeeId, objConn);

                    Employee emp = new Employee();
                    using (MySqlDataReader objSDR = objcmd.ExecuteReader())
                    {
                        while (objSDR.Read())
                        {
                            emp.EmployeeId = Convert.ToInt32(objSDR["EmployeeId"]);
                            emp.EmployeeName = Convert.ToString(objSDR["EmployeeName"]);
                            emp.LastName = Convert.ToString(objSDR["LastName"]);
                            emp.Designation = Convert.ToString(objSDR["Designation"]);
                            emp.Salary = Convert.ToInt32(objSDR["Salary"]);
                            emp.Experience = Convert.ToInt32(objSDR["experience"]);
                        }
                    }
                    return emp;

                }
                catch (MySqlException sqlex)
                {
                    Message = sqlex.InnerException.Message;
                    return null;
                }
                finally
                {
                    if (objConn.State == ConnectionState.Open)
                        objConn.Close();
                }
            }
        }

        /// <summary>
        /// Insert(Employee emp)
        /// method add new employee to Employee table
        /// </summary>
        /// <param name="emp">
        /// emp is object type of Employee 
        /// which contains EmployeeId,EmployeeName, LastName, Designation, Salary, Experience of Employee
        /// </param>
        /// <returns>boolean value true is operation succeed</returns>
        public Boolean Insert(Employee emp)
        {
            using (MySqlConnection objConn = new MySqlConnection(connectionstring))
            {
                objConn.Open();
                try
                {
                    MySqlCommand objcmd = new MySqlCommand("insert into EmployeeDetails (EmployeeName,LastName,Designation,Salary,experience) values ('" + emp.EmployeeName + "','" + emp.LastName + "','" + emp.Designation + "','" + emp.Salary + "','" + emp.Experience + "') ", objConn);
                    objcmd.ExecuteNonQuery();

                    return true;
                }
                catch (MySqlException sqlex)
                {
                    Message = sqlex.InnerException.Message.ToString();
                    return false;
                }
                finally
                {
                    if (objConn.State == ConnectionState.Open)
                        objConn.Close();
                }
            }
        }

        /// <summary>
        /// Delete(Int32 EmployeeId)
        /// method remove particular employee from the list
        /// whose id matches to the id given by user
        /// </summary>
        /// <param name="EmployeeId">EmployeeId is unique id for each employee</param>
        public void Delete(Int32 EmployeeId)
        {
            using (MySqlConnection objConn = new MySqlConnection(connectionstring))
            {
                objConn.Open();
                try
                {
                    MySqlCommand objcmd = new MySqlCommand("delete from employeedetails where EmployeeId = " + EmployeeId, objConn);

                    objcmd.ExecuteNonQuery();
                }
                catch (MySqlException sqlex)
                {
                    Message = sqlex.InnerException.Message;
                }
                catch (Exception ex)
                {
                    Message = ex.InnerException.Message;
                }
                finally
                {
                    if (objConn.State == ConnectionState.Open)
                        objConn.Close();
                }
            }
        }

        /// <summary>
        /// Update(Employee emp)
        ///  method edit EmployeeName Employee based on it's Id
        /// </summary>
        /// <param name="emp">
        /// emp is object type of Employee 
        /// which contains EmployeeId,EmployeeName, LastName, Designation, Salary, Experience of Employee
        /// </param>
        /// <returns>boolean value true is operation succeed</returns>
        public void Update(Employee emp)
        {
            using (MySqlConnection objConn = new MySqlConnection(connectionstring))
            {
                objConn.Open();
                try
                {
                    MySqlCommand objcmd = new MySqlCommand("update EmployeeDetails set EmployeeName = '" + emp.EmployeeName + "',LastName = '" + emp.LastName + "', Designation = '" + emp.Designation + "', Salary = '" + emp.Salary + "', experience = '" + emp.Experience + "' where EmployeeId = '" + emp.EmployeeId + "';", objConn);

                    objcmd.ExecuteNonQuery();
                }
                catch (MySqlException sqlex)
                {
                    Message = sqlex.InnerException.Message.ToString();

                }
                catch (Exception ex)
                {
                    Message = ex.InnerException.Message.ToString();

                }
                finally
                {
                    if (objConn.State == ConnectionState.Open)
                        objConn.Close();
                }
            }
        }
        #endregion Public Member Functions

    }
}