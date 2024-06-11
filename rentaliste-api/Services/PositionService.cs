using System;
using rentaliste_api.Models.dto;
using rentaliste_api.Services.Interfaces;


namespace rentaliste_api.Services
{
	public class PositionService : IPositionService
	{
		public PositionService()
		{
		}

        public bool AddPosition(PositionDto positionDto)
        {
            throw new NotImplementedException();
        }

        public bool DeletePosition(int id)
        {
            throw new NotImplementedException();
        }

        public PositionDto GetPositionById(int id)
        {
            throw new NotImplementedException();
        }

        public PositionDto GetPositionByLabel(string label)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PositionDto> GetPositions()
        {
            throw new NotImplementedException();
        }

        public bool UpdatePosition(PositionDto positionDto)
        {
            throw new NotImplementedException();
        }
    }
}

