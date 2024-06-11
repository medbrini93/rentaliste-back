﻿using System;
using rentaliste_api.Models;
using rentaliste_api.Models.db;
using rentaliste_api.Repository.Interfaces;


namespace rentaliste_api.Repository
{
	public class PositionRepository : GenericRepository<Position> , IPositionRepository
	{
		public PositionRepository(ApplicationContext context)
			:base(context)
		{
		}
	}
}

