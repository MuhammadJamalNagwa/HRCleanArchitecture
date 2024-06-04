using HRClean.Application.DTOs;
using HRClean.Application.Mapper;
using HRClean.Domain.Entities;
using HRClean.Domain.Repositories;

namespace HRClean.Application.UseCases.PositionUseCases;

public class CreatePositionHandler : ICreatePosition
{
    private readonly IPositionRepository _positionRepository;
	public CreatePositionHandler(IPositionRepository positionRepository)
	{
		_positionRepository = positionRepository;
	}

	public async Task<int> Handle(CreatePositionDTO position)
	{
		Position newPosition = position.ToEntity();

		return await _positionRepository.AddAsync(newPosition);
	}
}