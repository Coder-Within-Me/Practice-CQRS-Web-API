using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using WebApiProjectCQRS.DataProvider.DbContext;
using WebApiProjectCQRS.DataProvider.Repository.Interface;
using WebApiProjectCQRS.Domain;
using WebApiProjectCQRS.Response;

namespace WebApiProjectCQRS.DataProvider.Repository.Implementation
{
    public class GetAllEmployeesReader : IGetAllEmployees
    {
        private readonly EmpDbContext _dbContext;
        public GetAllEmployeesReader(EmpDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<EmployeeResponse>> GetAllEmployees()
        {
            var results = await (from emp in _dbContext.Employees
                                 join empD in _dbContext.EmployeeDetails
                                 on emp.EmpId equals empD.EmpId
                                 select new EmployeeResponse() { 
                                     EmpId = emp.EmpId,
                                     DOB = empD.DOB }).ToListAsync();

            //var results = await _dbContext.Employees.Include(x=> x.EmployeeDetails).ToListAsync();
            return results;
        }
    }
}
