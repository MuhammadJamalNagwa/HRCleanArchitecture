using HRClean.Application.DTOs;

namespace HRClean.Application.UseCases.DepartmentUseCases;
public interface ICreateDepartment
{
	public Task<int> Handle(CreateDepartmentDTO department);
}
