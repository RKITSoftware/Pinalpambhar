using System.ComponentModel.DataAnnotations;

namespace WebAPI_CRUD_Operations.Models
{
    public class Employee
    {

        /// <summary>
        /// EmployeeId defines unique id for each employee
        /// </summary>
        public int EmployeeId { get; set; }

        /// <summary>
        /// EmployeeName defines name for each employee
        /// </summary>
        [Required]
        [DataType(DataType.Text)]
        [StringLength(25)]
        public string EmployeeName { get; set; }

        /// <summary>
        /// LastName defines last name for each employee
        /// </summary>
        [Required]
        [DataType(DataType.Text)]
        [StringLength(25)]
        public string LastName { get; set; }

        /// <summary>
        /// Designation defines current post of each employee 
        /// </summary>
        [Required]
        [DataType(DataType.Text)]
        [StringLength(100)]
        public string Designation { get; set; }

        /// <summary>
        /// salary defines current salary of each employee
        /// </summary>
        [Required]
        [Range(0, 100000)]
        public int Salary { get; set; }

        /// <summary>
        /// Experience defines exprience in years of each employee
        /// </summary>
        [Required]
        public int Experience { get; set; }
    }
}