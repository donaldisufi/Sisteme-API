using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using school.Data;
using school.Interfaces;
using school.Models;

namespace school.Repository
{
	public class ProffesorsRepository : IProffesorsRepository
	{
		private readonly schoolContext _context;

		public ProffesorsRepository(schoolContext context)
		{
			_context = context;
		}

		public Task<Proffesors> Add(Proffesors t)
		{
			throw new NotImplementedException();
		}

		public Task<Proffesors> Get(int id)
		{
			throw new NotImplementedException();
		}

		public Task<IEnumerable<Proffesors>> GetAll()
		{
			throw new NotImplementedException();
		}

		public Task<Proffesors> Remove(int id)
		{
			throw new NotImplementedException();
		}

		public Task<Proffesors> Update(int id, Proffesors newT)
		{
			throw new NotImplementedException();
		}
	}
}
