using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiProjectCQRS.Response;

namespace WebApiProjectCQRS.Request.Query
{
    public class QueryGetAllEmployees : IRequest<List<EmployeeResponse>>
    {
    }
}
