using school.Models;
using System.Threading.Tasks;

namespace school.Interfaces
{
	public interface IUser<T>
	{
		Task<T> Login(LoginModel obj);
	}
}