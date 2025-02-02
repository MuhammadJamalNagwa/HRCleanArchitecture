﻿using HRClean.Domain.Entities;

namespace HRClean.Domain.Repositories;

public interface IPositionRepository
{
	Task<Position?> GetByIdAsync(int id);
	Task<IEnumerable<Position>> GetAllAsync();
	Task<int> AddAsync(Position position);
	Task UpdateAsync(Position position);
	Task DeleteAsync(int id);
}