using school.Data;
using school.Interfaces;
using school.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace school.Repository
{
	public class AfatetRepository : IAfatetRepository
	{
		private readonly schoolContext _context;

		public AfatetRepository(schoolContext context)
		{
			_context = context;
		}

		public Task<Afatet> Add(Afatet t)
		{
			throw new NotImplementedException();
		}

		public Task<Afatet> Get(int id)
		{
			throw new NotImplementedException();
		}

		public Task<IEnumerable<Afatet>> GetAll()
		{
			throw new NotImplementedException();
		}

		public Task<Afatet> Remove(int id)
		{
			throw new NotImplementedException();
		}

		public Task<Afatet> Update(int id, Afatet newT)
		{
			throw new NotImplementedException();
		}
	}
}
