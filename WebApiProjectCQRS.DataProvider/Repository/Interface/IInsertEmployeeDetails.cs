using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiProjectCQRS.Domain;

namespace WebApiProjectCQRS.DataProvider.Repository.Interface
{
    public interface IInsertEmployeeDetails
    {
        Task<bool> InsertEmployeeDetails(Employee emp);
    }
}
