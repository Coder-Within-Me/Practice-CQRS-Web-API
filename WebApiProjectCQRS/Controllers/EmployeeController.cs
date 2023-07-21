using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MediatR;
using WebApiProjectCQRS.Response;
using WebApiProjectCQRS.Request.Query;
using WebApiProjectCQRS.DataProvider.Repository.Interface;
using WebApiProjectCQRS.DataProvider.Repository.Implementation;
using WebApiProjectCQRS.Request.Command;
using WebApiProjectCQRS.Domain;

namespace WebApiProjectCQRS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IMediator _mediator;
        public EmployeeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("GetAllEmployees")]
        public async Task<ActionResult<List<EmployeeResponse>>> GetAllEmployees()
        {
            var data = new QueryGetAllEmployees() { };
            var response = await _mediator.Send(data);
            if (response == null)
                return NotFound();

            return response;
        }
        [HttpPost]
        public async Task<ActionResult<bool>> InsertEmployeeDeatils([FromBody]CommandInsertEmployeeDetails employee)
        {
            var response = await _mediator.Send(employee);
            if (response == null)
                return NotFound();
            return response;
        }
    }
}
