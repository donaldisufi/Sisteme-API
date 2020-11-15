using System;
using System.Collections.Generic;
using System.Linq;
using school.Interfaces;
using System.Threading.Tasks;
using school.Models;
using school.Data;

namespace school.Repository
{
	public class UserRepository : IUser<User>
	{
		private readonly schoolContext _context;

		public UserRepository(schoolContext context)
		{
			_context = context;
		}

		public async Task<User> Login(LoginModel obj)
		{
			var userList = await Task.Run(()=> _context.User.ToList());   //(u => u.UserName == obj.Username && u.Password == obj.Password);
			User user = null;

			foreach(var item in userList)
			{
				if(item.UserName == obj.Username && item.Password == obj.Password)
				{
					user = item;
				}
			}
			if (user != null)
			{
				user.Token = TokenProvider.GenerateToken(user);
				user.Role = new Role() { RoleName = "admin", Id = 1 };
				return user;
			}
			return null;
		}
	}
}
