using HRClean.Application.DTOs;

namespace HRClean.Application.UseCases.EmployeeUseCases;
public interface ICreateEmployee
{
	public Task<int> Handle(CreateEmployeeDTO employee);
}
