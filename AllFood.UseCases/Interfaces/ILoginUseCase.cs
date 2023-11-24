using AllFood.UseCases.Dtos.Input;
using AllFood.UseCases.Dtos.Output;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllFood.UseCases.Interfaces
{
    public interface ILoginUseCase
    {
        Task<LoginOutputDto> AuthenticateUser(LoginInputDto loginUseCaseDto);
    }
}
