using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlTypes;
using WebAPI_CRUD_Operations.Models;

namespace WebAPI_CRUD_Operations.Controllers
{
    public class EmployeeDetails
    {
        string connectionstring = ConfigurationManager.ConnectionStrings["EmployeeConnectionString"].ConnectionString;
        string Message;

        #region Get All Data
        public List<Employee> GetAllEmployees()
        {
            using (MySqlConnection objconn = new MySqlConnection(connectionstring))
            {
                objconn.Open();
                using (MySqlCommand objcmd = objconn.CreateCommand())
                {
                    try
                    {
                        #region Prepare Command
                        objcmd.CommandType = CommandType.StoredProcedure;
                        objcmd.CommandText = "PR_Employee_SelectAll";
                        #endregion Prepare Command

                        #region ReadData and Set Controls
                        List<Employee> employee = new List<Employee>();
                        Employee emp = new Employee();
                        using (MySqlDataReader objSDR = objcmd.ExecuteReader())
                        {
                            while (objSDR.Read())
                            {
                                employee.Add(new Employee { EmployeeId = (Convert.ToInt32(objSDR[0])), EmployeeName = (Convert.ToString(objSDR[1])) });
                            }
                        }
                        return employee;
                        #endregion ReadData and Set Controls
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
        }
        #endregion Get All Data

        #region SelectByPK
        public Employee GetEmployeeById(SqlInt32 Id)
        {
            using (MySqlConnection objConn = new MySqlConnection(connectionstring))
            {
                objConn.Open();
                using (MySqlCommand objcmd = objConn.CreateCommand())
                {
                    try
                    {
                        #region Prepare Command
                        objcmd.CommandType = CommandType.StoredProcedure;
                        objcmd.CommandText = "PR_Employee_SelectByPK";
                        objcmd.Parameters.AddWithValue("@EmployeeId", Id);
                        #endregion Prepare Command

                        #region ReadData and Set Controls
                        Employee emp = new Employee();
                        using (MySqlDataReader objSDR = objcmd.ExecuteReader())
                        {
                            while (objSDR.Read())
                            {
                                emp.EmployeeId = Convert.ToInt32(objSDR[0]);
                                emp.EmployeeName = Convert.ToString(objSDR[1]);
                            }
                        }
                        return emp;
                        #endregion ReadData and Set Controls
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
        }
        #endregion SelectByPK 

        #region Insert Operation
        public Boolean Insert(Employee emp)
        {
            using (MySqlConnection objConn = new MySqlConnection(connectionstring))
            {
                objConn.Open();
                using (MySqlCommand objCmd = objConn.CreateCommand())
                {
                    try
                    {
                        #region Prepare Command
                        objCmd.CommandType = CommandType.StoredProcedure;
                        objCmd.CommandText = "PR_Employee_Insert";
                        objCmd.Parameters.Add("@EmployeeName", MySqlDbType.VarChar).Value = emp.EmployeeName;

                        #endregion Prepare Command

                        objCmd.ExecuteNonQuery();

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
        }
        #endregion Insert Operation

        #region Delete Operation
        public void Delete(Int32 EmployeeId)
        {
            using (MySqlConnection objConn = new MySqlConnection(connectionstring))
            {
                objConn.Open();
                using (MySqlCommand objcmd = objConn.CreateCommand())
                {
                    try
                    {
                        #region Prepare Command
                        objcmd.CommandType = CommandType.StoredProcedure;
                        objcmd.CommandText = "PR_Employee_DeleteByPK";
                        objcmd.Parameters.AddWithValue("@EmployeeId", EmployeeId);
                        #endregion Prepare Command

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
        }
        #endregion Delete Operation

        #region Update Operation
        public Boolean Update(Employee emp)
        {
            using (MySqlConnection objConn = new MySqlConnection(connectionstring))
            {
                objConn.Open();
                using (MySqlCommand objCmd = objConn.CreateCommand())
                {
                    try
                    {
                        #region Prepare Command
                        objCmd.CommandType = CommandType.StoredProcedure;
                        objCmd.CommandText = "PR_Employee_UpdateByPK";
                        objCmd.Parameters.AddWithValue("@EmployeeId", emp.EmployeeId);
                        objCmd.Parameters.AddWithValue("@EmployeeName", emp.EmployeeName);
                        #endregion Prepare Command

                        objCmd.ExecuteNonQuery();

                        return true;

                    }
                    catch (MySqlException sqlex)
                    {
                        Message = sqlex.InnerException.Message.ToString();
                        return false;
                    }
                    catch (Exception ex)
                    {
                        Message = ex.InnerException.Message.ToString();
                        return false;
                    }
                    finally
                    {
                        if (objConn.State == ConnectionState.Open)
                            objConn.Close();
                    }
                }
            }
        }
        #endregion Update Operation
    }
}