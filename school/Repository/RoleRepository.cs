using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using school.Data;
using school.Interfaces;
using school.Models;

namespace school.Repository
{
	public class RoleRepository : IRoleRepository
	{
		private readonly schoolContext _context;

		public RoleRepository(schoolContext context)
		{
			_context = context;
		}

		public Task<Role> Add(Role t)
		{
			throw new NotImplementedException();
		}

		public Task<Role> Get(int id)
		{
			throw new NotImplementedException();
		}

		public Task<IEnumerable<Role>> GetAll()
		{
			throw new NotImplementedException();
		}

		public Task<Role> Remove(int id)
		{
			throw new NotImplementedException();
		}

		public Task<Role> Update(int id, Role newT)
		{
			throw new NotImplementedException();
		}
	}
}
