using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiProjectCQRS.Domain
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmpId { get; set; }
        public string? EmpName { get; set; }
        public string? Department { get; set; }
        public DateTime JoiningDate { get; set; }
        public decimal Salary { get; set; }

        public bool IsActive { get; set; }

        public EmployeeDetails EmployeeDetails { get; set; }

        //public ICollection<EmployeeDetails>? EmployeeDetails { get; set; }
    }
}