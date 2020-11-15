using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using school.Data;
using school.Interfaces;
using school.Models;

namespace school.Repository
{
	public class StudentRepository : IStudentRepository
	{
		private readonly schoolContext _context;

		public StudentRepository(schoolContext context)
		{
			_context = context;
		}

		public Task<Students> Add(Students t)
		{
			throw new NotImplementedException();
		}

		public Task<Students> Get(int id)
		{
			throw new NotImplementedException();
		}

		public Task<IEnumerable<Students>> GetAll()
		{
			throw new NotImplementedException();
		}

		public Task<Students> Remove(int id)
		{
			throw new NotImplementedException();
		}

		public Task<Students> Update(int id, Students newT)
		{
			throw new NotImplementedException();
		}
	}
}
