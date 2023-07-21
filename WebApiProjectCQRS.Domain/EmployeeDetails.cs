using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiProjectCQRS.Domain
{
    public class EmployeeDetails
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [ForeignKey("Employee")]
        public int EmpId { get; set; }
        public long ContactNumber { get; set; }
        public string? Address { get; set; }
        public DateTime DOB { get; set; }

        //public Employee Employee { get; set; }
    }
}
