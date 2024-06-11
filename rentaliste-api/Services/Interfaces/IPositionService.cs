using System;
using rentaliste_api.Models.dto;

namespace rentaliste_api.Services.Interfaces
{
	public interface IPositionService
	{
        IEnumerable<PositionDto> GetPositions();

        PositionDto GetPositionById(int id);

        PositionDto GetPositionByLabel(string label);

        bool AddPosition(PositionDto positionDto);

        bool UpdatePosition(PositionDto positionDto);

        bool DeletePosition(int id);
    }
}

