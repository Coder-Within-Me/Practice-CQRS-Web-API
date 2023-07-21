using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiProjectCQRS.DataProvider.Repository.Implementation;
using WebApiProjectCQRS.DataProvider.Repository.Interface;
using WebApiProjectCQRS.Domain;
using WebApiProjectCQRS.Request.Command;
using WebApiProjectCQRS.Request.Query;
using WebApiProjectCQRS.Response;

namespace WebApiProjectCQRS.Service
{
    public class InsertEmployeeDetailsHandler : IRequestHandler<CommandInsertEmployeeDetails, bool>
    {
        private readonly IInsertEmployeeDetails _IInsertEmployeeDetailsWriter;

        private readonly IMapper _mapper;

        public InsertEmployeeDetailsHandler(IInsertEmployeeDetails InsertEmployeeDetails, IMapper mapper)
        {
            _IInsertEmployeeDetailsWriter = InsertEmployeeDetails;

            _mapper = mapper;
        }

        public async Task<bool> Handle(CommandInsertEmployeeDetails request, CancellationToken cancellationToken)
        {
            var employees = await _IInsertEmployeeDetailsWriter.InsertEmployeeDetails(_mapper.Map<Employee>(request));
            return employees;
        }
    }
}
