using System;
using System.Collections.Generic;
using System.Linq;
using school.Interfaces;
using System.Threading.Tasks;
using school.Models;
using school.Data;

namespace school.Repository
{
	public class SubjectRepository : ISubjectRepository
	{
		private readonly schoolContext _context;

		public SubjectRepository(schoolContext context)
		{
			_context = context;
		}

		public Task<Subjects> Add(Subjects t)
		{
			throw new NotImplementedException();
		}

		public Task<Subjects> Get(int id)
		{
			throw new NotImplementedException();
		}

		public Task<IEnumerable<Subjects>> GetAll()
		{
			throw new NotImplementedException();
		}

		public Task<Subjects> Remove(int id)
		{
			throw new NotImplementedException();
		}

		public Task<Subjects> Update(int id, Subjects newT)
		{
			throw new NotImplementedException();
		}
	}
}
