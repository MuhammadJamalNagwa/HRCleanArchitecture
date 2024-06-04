using API.Extensions;
using HRClean.Application.UseCases.DepartmentUseCases;
using HRClean.Application.UseCases.EmployeeUseCases;
using HRClean.Application.UseCases.PositionUseCases;
using HRClean.Domain.Repositories;
using HRClean.Persistence.Database;
using HRClean.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
{
	// Add services to the container.
	// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
	builder.Services.AddEndpointsApiExplorer();
	builder.Services.AddSwaggerGen();

	builder.Services.AddScoped<ICreateDepartment, CreateDepartmentHandler>();
	builder.Services.AddScoped<IGetDepartmentById, GetDepartmentByIdHandler>();

	builder.Services.AddScoped<ICreateEmployee, CreateEmployeeHandler>();
	builder.Services.AddScoped<IGetEmployeeById, GetEmployeeByIdHandler>();

	builder.Services.AddScoped<ICreatePosition, CreatePositionHandler>();
	builder.Services.AddScoped<IGetPositionById, GetPositionByIdHandler>();

	builder.Services.AddScoped<IPositionRepository, PositionRepository>();
	builder.Services.AddScoped<IDepartmentRepository, DepartmentRepository>();
	builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();

	string? connectionString = builder.Configuration.GetConnectionString("DefaultConnection")
									?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

	builder.Services.AddDbContextPool<ApplicationDbContext>(options =>
	{
		options.UseSqlServer(connectionString);
		options.UseLazyLoadingProxies();
	});
}


WebApplication app = builder.Build();
{
	// Configure the HTTP request pipeline.
	if (app.Environment.IsDevelopment())
	{
		app.UseSwagger();
		app.UseSwaggerUI();
	}

	app.UseHttpsRedirection();

	app.MapPositionEndpoints();
	app.MapEmployeeEndpoints();
	app.MapDepartmentEndpoints();

	app.Run();
}
