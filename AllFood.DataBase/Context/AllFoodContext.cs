using AllFood.DataBase.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AllFood.DataBase.Context
{

    public class AllFoodContext : DbContext
    {

        public AllFoodContext(DbContextOptions<AllFoodContext> options) : base(options)
        {

        }

        public virtual DbSet<User> Users { get; set; }

    }
}


