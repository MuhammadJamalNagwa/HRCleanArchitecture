using HRClean.Application.DTOs;

namespace HRClean.Application.UseCases.PositionUseCases;
public interface IGetPositionById
{
	Task<PositionDTO> Handle(int id);
}
