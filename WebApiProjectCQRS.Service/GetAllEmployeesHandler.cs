using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiProjectCQRS.DataProvider.Repository.Interface;
using WebApiProjectCQRS.Request.Query;
using WebApiProjectCQRS.Response;

namespace WebApiProjectCQRS.Service
{
    public class GetAllEmployeesHandler : IRequestHandler<QueryGetAllEmployees, List<EmployeeResponse>>
    {
        private readonly IGetAllEmployees _GetAllEmployeesReader;

        private readonly IMapper _mapper;

        public GetAllEmployeesHandler(IGetAllEmployees GetAllEmployees, IMapper mapper)
        {
            _GetAllEmployeesReader = GetAllEmployees;

            _mapper = mapper;
        }

        public async Task<List<EmployeeResponse>> Handle(QueryGetAllEmployees request, CancellationToken cancellationToken)
        {
            var employees = await _GetAllEmployeesReader.GetAllEmployees();
            return _mapper.Map<List<EmployeeResponse>>(employees);
        }

       
    }
}
