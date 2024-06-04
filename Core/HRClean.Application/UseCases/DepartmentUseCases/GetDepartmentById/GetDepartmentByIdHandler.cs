using HRClean.Application.DTOs;
using HRClean.Application.Mapper;
using HRClean.Domain.Entities;
using HRClean.Domain.Repositories;

namespace HRClean.Application.UseCases.DepartmentUseCases;
public class GetDepartmentByIdHandler : IGetDepartmentById
{
    private readonly IDepartmentRepository _departmentRepository;

	public GetDepartmentByIdHandler(IDepartmentRepository departmentRepository)
	{
		_departmentRepository = departmentRepository;
	}

    public async Task<DepartmentDTO> Handle(int id)
	{
		return (await _departmentRepository.GetByIdAsync(id)).ToDTO();
	}
}
