using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AllFood.DataBase.Entities;


namespace AllFood.Domain.Entities
{
    public class Login
    {
        public User User { get; set; }
        public string Token { get; set; }
    }
}
