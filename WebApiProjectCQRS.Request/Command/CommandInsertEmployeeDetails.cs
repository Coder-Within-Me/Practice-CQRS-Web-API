using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiProjectCQRS.Response;

namespace WebApiProjectCQRS.Request.Command
{
    public class CommandInsertEmployeeDetails : IRequest<bool>
    {
        public string? EmpName { get; set; }
        public string? Department { get; set; }
        public DateTime JoiningDate { get; set; }
        public decimal Salary { get; set; }

        public bool IsActive { get; set; }
        public int ContactNumber { get; set; }
        public string? Address { get; set; }
        public DateTime DOB { get; set; }
    }
}
