using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiProjectCQRS.Domain;
using WebApiProjectCQRS.Response;

namespace WebApiProjectCQRS.DataProvider.Repository.Interface
{
    public interface IGetAllEmployees
    {
        Task<List<EmployeeResponse>> GetAllEmployees();
    }
}
