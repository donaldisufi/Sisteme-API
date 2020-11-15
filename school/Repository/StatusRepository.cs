using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using school.Data;
using school.Interfaces;
using school.Models;

namespace school.Repository
{
	public class StatusRepository : IStatusRepository
	{
		private readonly schoolContext _context;

		public StatusRepository(schoolContext context)
		{
			_context = context;
		}

		public Task<Status> Add(Status t)
		{
			throw new NotImplementedException();
		}

		public Task<Status> Get(int id)
		{
			throw new NotImplementedException();
		}

		public Task<IEnumerable<Status>> GetAll()
		{
			throw new NotImplementedException();
		}

		public Task<Status> Remove(int id)
		{
			throw new NotImplementedException();
		}

		public Task<Status> Update(int id, Status newT)
		{
			throw new NotImplementedException();
		}
	}
}
