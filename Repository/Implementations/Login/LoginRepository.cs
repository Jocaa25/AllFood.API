using AllFood.DataBase.Context;
using AllFood.DataBase.Entities;
using AllFood.Infrastructure.Interfaces.Login;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllFood.Infrastructure.Implementations.Login
{
    public class LoginRepository : ILoginRepository
    {
        private readonly AllFoodContext allFoodContext;
        public LoginRepository(AllFoodContext _allFoodContext)
        {
            allFoodContext = _allFoodContext;
        }
        public Task<User> signInAuthentication(User user)
        {
            try
            {
                var UserData = allFoodContext.Users.Where(u => u.Username.Equals(user.Username)).FirstOrDefault();
                return  Task.FromResult(UserData);
            }
            catch (Exception)
            {
                throw new Exception("Internal Server Error");
            }
        }
    }
}
