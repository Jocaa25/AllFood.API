using AllFood.UseCases.Dtos;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AllFood.DataBase.Entities;
namespace AllFood.UseCases.AutoMapping.Input
{
    public class InputToEntityMapping : Profile
    {
        public InputToEntityMapping()
        {
            CreateMap<LoginUseCaseDto, User>();
        }
    }
}
