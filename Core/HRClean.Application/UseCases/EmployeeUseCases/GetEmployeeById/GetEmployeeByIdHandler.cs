using HRClean.Application.DTOs;
using HRClean.Application.Mapper;
using HRClean.Domain.Repositories;

namespace HRClean.Application.UseCases.EmployeeUseCases;
public class GetEmployeeByIdHandler : IGetEmployeeById
{
    private readonly IEmployeeRepository _employeeRepository;
	public GetEmployeeByIdHandler(IEmployeeRepository employeeRepository)
	{
		_employeeRepository = employeeRepository;
	}
	public async Task<EmployeeDTO> Handle(int id)
	{
		return (await _employeeRepository.GetByIdAsync(id)).ToDTO();
	}
}
