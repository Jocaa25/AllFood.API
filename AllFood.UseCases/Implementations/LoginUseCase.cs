using AllFood.UseCases.Dtos;
using AllFood.UseCases.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using AllFood.Domain.Entities;


namespace AllFood.UseCases.Implementations
{
    public class LoginUseCase : ILoginUseCase
    {
        private readonly IMapper mapper;

        public LoginUseCase(IMapper _mapper)
        {
            mapper = _mapper;
        }
        public Task<LoginUseCaseDto> AuthenticateUser(LoginUseCaseDto loginUseCaseDto)
        {
            try
            {
                var login = mapper.Map<Login>(loginUseCaseDto);// mapeamento para as entidades do banco;
                if (loginUseCaseDto.User.Username.ToLower().Equals("joca") || loginUseCaseDto.User.PasswordHash.Equals("1234"))
                {
                    loginUseCaseDto.Message = "user successfully authenticated";
                    return Task.FromResult(loginUseCaseDto);
                }
                else
                {
                    loginUseCaseDto.Message = "Invalid username or password";
                }

                return Task.FromResult(loginUseCaseDto);

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
