using HRClean.Application.DTOs;
using HRClean.Application.UseCases.DepartmentUseCases;

namespace API.Extensions;

public static class DepartmentEndpoints
{
	public static void MapDepartmentEndpoints(this IEndpointRouteBuilder app)
	{
		app.MapPost("/api/departments", async (CreateDepartmentDTO newDepartment, ICreateDepartment createDepartment) =>
		{
			int departmentId = await createDepartment.Handle(newDepartment);

			return Results.Ok(departmentId);
		});

		app.MapGet("/api/departments/{id}", async (int id, IGetDepartmentById getDepartment) =>
		{
			DepartmentDTO department = await getDepartment.Handle(id);

			return Results.Ok(department);
		});

		//app.MapGet("/api/departments", async (DepartmentService departmentService) =>
		//{
		//	IEnumerable<DepartmentDTO> departments = await departmentService.GetAllDepartments();

		//	return Results.Ok(departments);
		//});
	}
}
