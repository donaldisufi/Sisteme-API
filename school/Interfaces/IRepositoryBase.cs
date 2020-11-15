using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace school.Interfaces
{
	public interface IRepositoryBase<T>
	{
		Task<IEnumerable<T>> GetAll();
		Task<T> Add(T t);
		Task<T> Get(int id);
		Task<T> Remove(int id);
		Task<T> Update(int id, T newT);
	}
}
