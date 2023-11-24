using AllFood.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllFood.UseCases.Dtos.Output
{
    public class LoginOutputDto
    {
        public User User { get; set; }
        public string message { get; set; }
    }
}
