using AllFood.UseCases.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllFood.UseCases.Interfaces
{
    public interface ILoginUseCase
    {
        Task<LoginUseCaseDto> AuthenticateUser(LoginUseCaseDto loginUseCaseDto);
    }
}
