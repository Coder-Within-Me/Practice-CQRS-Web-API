using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiProjectCQRS.DataProvider.DbContext;
using WebApiProjectCQRS.DataProvider.Repository.Interface;
using WebApiProjectCQRS.Domain;

namespace WebApiProjectCQRS.DataProvider.Repository.Implementation
{
    public class InsertEmployeeDetailsWriter : IInsertEmployeeDetails
    {
        private readonly EmpDbContext _dbContext;
        public InsertEmployeeDetailsWriter(EmpDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<bool> InsertEmployeeDetails(Employee emp)
        {
            //var results = await _dbContext.Employees.ToListAsync();
            return true;
        }
    }
}
