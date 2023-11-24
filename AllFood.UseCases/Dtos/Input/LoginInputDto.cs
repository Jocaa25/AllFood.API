using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AllFood.UseCases.Interfaces;
using AllFood.Domain.Entities;

namespace AllFood.UseCases.Dtos.Input
{
    public class LoginInputDto
    {
        public User User { get; set; }
    }
}
