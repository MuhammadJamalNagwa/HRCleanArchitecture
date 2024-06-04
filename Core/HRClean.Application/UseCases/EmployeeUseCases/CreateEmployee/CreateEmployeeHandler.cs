using HRClean.Application.DTOs;
using HRClean.Application.Mapper;
using HRClean.Domain.Entities;
using HRClean.Domain.Repositories;

namespace HRClean.Application.UseCases.EmployeeUseCases;

public class CreateEmployeeHandler : ICreateEmployee
{
    private readonly IEmployeeRepository _employeeReposiory;
	public CreateEmployeeHandler(IEmployeeRepository employeeReposiory)
	{
		_employeeReposiory = employeeReposiory;
	}

	public async Task<int> Handle(CreateEmployeeDTO employee)
	{
		Employee newEmployee = employee.ToEntity();

		return await _employeeReposiory.AddAsync(newEmployee);
	}
}