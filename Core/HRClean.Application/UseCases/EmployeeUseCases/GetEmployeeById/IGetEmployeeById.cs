using HRClean.Application.DTOs;

namespace HRClean.Application.UseCases.EmployeeUseCases;
public interface IGetEmployeeById
{
	public Task<EmployeeDTO> Handle(int id);
}
