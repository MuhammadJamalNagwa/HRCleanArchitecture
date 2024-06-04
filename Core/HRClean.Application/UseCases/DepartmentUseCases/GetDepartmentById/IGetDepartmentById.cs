using HRClean.Application.DTOs;

namespace HRClean.Application.UseCases.DepartmentUseCases;
public interface IGetDepartmentById
{
	public Task<DepartmentDTO> Handle(int id);
}
