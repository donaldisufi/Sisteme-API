using System;
using System.Collections.Generic;
using System.Linq;
using school.Interfaces;
using System.Threading.Tasks;
using school.Models;
using school.Data;

namespace school.Repository
{
	public class ExamsRepository : IExamsRepository
	{
		private readonly schoolContext _context;

		public ExamsRepository(schoolContext context)
		{
			_context = context;
		}

		public Task<Exams> Add(Exams t)
		{
			throw new NotImplementedException();
		}

		public Task<Exams> Get(int id)
		{
			throw new NotImplementedException();
		}

		public Task<IEnumerable<Exams>> GetAll()
		{
			throw new NotImplementedException();
		}

		public Task<Exams> Remove(int id)
		{
			throw new NotImplementedException();
		}

		public Task<Exams> Update(int id, Exams newT)
		{
			throw new NotImplementedException();
		}
	}
}
