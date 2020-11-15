using school.Data;
using school.Interfaces;
using school.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace school.Repository
{
	public class DirectionRepository : IDirectionsRepository
	{
		private readonly schoolContext _context;

		public DirectionRepository(schoolContext context)
		{
			_context = context;
		}

		public Task<Directions> Add(Directions t)
		{
			throw new NotImplementedException();
		}

		public Task<Directions> Get(int id)
		{
			throw new NotImplementedException();
		}

		public Task<IEnumerable<Directions>> GetAll()
		{
			throw new NotImplementedException();
		}

		public Task<Directions> Remove(int id)
		{
			throw new NotImplementedException();
		}

		public Task<Directions> Update(int id, Directions newT)
		{
			throw new NotImplementedException();
		}
	}
}
