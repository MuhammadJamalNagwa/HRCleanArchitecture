using HRClean.Application.DTOs;

namespace HRClean.Application.UseCases.PositionUseCases;
public interface ICreatePosition
{
	Task<int> Handle(CreatePositionDTO position);
}
