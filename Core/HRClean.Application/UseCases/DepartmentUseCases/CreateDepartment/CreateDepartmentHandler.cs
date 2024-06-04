using HRClean.Application.DTOs;
using HRClean.Application.Mapper;
using HRClean.Domain.Entities;
using HRClean.Domain.Repositories;

namespace HRClean.Application.UseCases.DepartmentUseCases;

public class CreateDepartmentHandler : ICreateDepartment
{
	private readonly IDepartmentRepository _departmentRepository;
	public CreateDepartmentHandler(IDepartmentRepository departmentRepository)
	{
		_departmentRepository = departmentRepository;
	}

	public async Task<int> Handle(CreateDepartmentDTO department)
	{
		Department newDepartment = department.ToEntity();

		return await _departmentRepository.AddAsync(newDepartment);
	}
}