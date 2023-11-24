using AllFood.UseCases.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using AllFood.Infrastructure.Interfaces.Login;
using System.Reflection.Metadata;
using AllFood.DataBase.Entities;
using AllFood.UseCases.Dtos.Input;
using AllFood.Domain.Entities;
using User = AllFood.Domain.Entities.User;
using AllFood.UseCases.Dtos.Output;

namespace AllFood.UseCases.Implementations
{
    public class LoginUseCase : ILoginUseCase
    {
        private readonly IMapper mapper;
        private readonly ILoginRepository loginRepository;

        public LoginUseCase(IMapper _mapper, ILoginRepository _loginRepository)
        {
            mapper = _mapper;
            loginRepository = _loginRepository;
        }
        public Task<LoginOutputDto> AuthenticateUser(LoginInputDto loginUseCaseDto)
        {
            try
            {
                var login = mapper.Map<DataBase.Entities.User>(loginUseCaseDto.User);// mapeamento para as entidades do banco;
                var authentication = loginRepository.signInAuthentication(login);
                var userCallBack = mapper.Map<Domain.Entities.User>(authentication.Result);
                var message = "";
                userCallBack.PasswordHash = "";
                if (loginUseCaseDto.User.Username.ToLower().Equals(authentication.Result.Username) || loginUseCaseDto.User.PasswordHash.Equals(authentication.Result.PasswordHash))
                {
                    message = "user successfully authenticated";
                }
                else
                {
                   message = "Invalid username or password";
                }

                var loginOutputDto = new LoginOutputDto
                {
                    User = userCallBack,
                    message = message
                };

                return Task.FromResult(loginOutputDto);

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
