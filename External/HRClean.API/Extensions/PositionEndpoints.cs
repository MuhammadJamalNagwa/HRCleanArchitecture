using HRClean.Application.DTOs;
using HRClean.Application.UseCases.PositionUseCases;

namespace API.Extensions;

public static class PositionEndpoints
{
	public static void MapPositionEndpoints(this IEndpointRouteBuilder app)
	{
		app.MapPost("/api/positions", async (CreatePositionDTO newPosition, ICreatePosition createPosition) =>
		{
			int positionId = await createPosition.Handle(newPosition);

			return Results.Ok(positionId);
		});

		app.MapGet("/api/positions/{id}", async (int id, IGetPositionById getPositionById) =>
		{
			PositionDTO position = await getPositionById.Handle(id);

			return Results.Ok(position);
		});

		//app.MapGet("/api/positions", async (PositionService positionService) =>
		//{
		//	IEnumerable<PositionDTO> positions = await positionService.GetAllPositions();

		//	return Results.Ok(positions);
		//});
	}
}
