using HRClean.Application.DTOs;
using HRClean.Application.Mapper;
using HRClean.Domain.Repositories;

namespace HRClean.Application.UseCases.PositionUseCases;

public class GetPositionByIdHandler : IGetPositionById
{
    private readonly IPositionRepository _positionRepository;
	public GetPositionByIdHandler(IPositionRepository positionRepository)
	{
		_positionRepository = positionRepository;
	}

	public async Task<PositionDTO> Handle(int id)
	{
		return (await _positionRepository.GetByIdAsync(id)).ToDTO();
	}
}