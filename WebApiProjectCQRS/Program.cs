using Microsoft.EntityFrameworkCore;
using WebApiProjectCQRS.DataProvider;
using WebApiProjectCQRS.DataProvider.DbContext;
using WebApiProjectCQRS.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<EmpDbContext>(opts =>
    opts.UseSqlServer(builder.Configuration.GetConnectionString("SqlDbConnection"),
    providerOptions => providerOptions.EnableRetryOnFailure()));

ConfigureServicesAction.Execute(builder.Services);

ConfigureDataProviderAction.Execute(builder.Services);

//builder.Services.AddTransient<IGetAllEmployees, GetAllEmployeesReader>();
//builder.Services.AddTransient<IInsertEmployeeDetails, InsertEmployeeDetailsWriter>();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthorization();

app.MapControllers();

app.Run();
