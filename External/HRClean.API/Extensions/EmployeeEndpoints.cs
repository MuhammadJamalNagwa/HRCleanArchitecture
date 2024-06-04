using HRClean.Application.DTOs;
using HRClean.Application.UseCases.EmployeeUseCases;

namespace API.Extensions;

public static class EmployeeEndpoints
{
	public static void MapEmployeeEndpoints(this IEndpointRouteBuilder app)
	{
		app.MapPost("/api/employees", async (CreateEmployeeDTO newEmployee, ICreateEmployee createDepartment) =>
		{
			int employeeId = await createDepartment.Handle(newEmployee);

			return Results.Ok(employeeId);
		});

		app.MapGet("/api/employees/{id}", async (int id, IGetEmployeeById getEmployeeById) =>
		{
			EmployeeDTO employee = await getEmployeeById.Handle(id);

			return Results.Ok(employee);
		});

		//app.MapGet("/api/employees", async (EmployeeService employeeService) =>
		//{
		//	IEnumerable<EmployeeDTO> employees = await employeeService.GetAllEmployees();

		//	return Results.Ok(employees);
		//});
	}
}