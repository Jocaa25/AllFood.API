using AllFood.UseCases.Implementations;
using AllFood.UseCases.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using AllFood.UseCases.Dtos;
using AllFood.API.Dtos.Login;

namespace AllFood.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILoginUseCase loginUseCase;
        private readonly IMapper mapper;

        public LoginController(ILoginUseCase _loginUseCase, IMapper _mapper)
        {
            loginUseCase = _loginUseCase;
            mapper = _mapper;
        }
         [HttpPost]
        public async Task<ActionResult<LoginResponseDto>> Login([FromBody] LoginUseCaseDto request)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                var result = await loginUseCase.AuthenticateUser(request);

                var response = new LoginResponseDto
                {
                    Message = result.Message
                };

                return Ok(response);

            }
            catch (Exception)
            {

                throw;
            }
        }
    }


}
