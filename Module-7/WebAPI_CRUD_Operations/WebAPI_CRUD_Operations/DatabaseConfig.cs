using System.Configuration;

namespace WebAPI_CRUD_Operations
{
    public class DatabaseConfig
    {
        public string connectionstring = ConfigurationManager.ConnectionStrings["EmployeeConnectionString"].ConnectionString;
    }
}