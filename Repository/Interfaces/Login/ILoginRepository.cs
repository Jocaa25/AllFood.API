using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AllFood.DataBase.Entities;

namespace AllFood.Infrastructure.Interfaces.Login
{
    public interface ILoginRepository
    {
        Task<User> signInAuthentication(User user);
    }
}
