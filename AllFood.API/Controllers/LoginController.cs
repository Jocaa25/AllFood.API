using AllFood.UseCases.Implementations;
using AllFood.UseCases.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using AllFood.UseCases.Dtos.Input;
using AllFood.UseCases.Dtos.Output;

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
        [Route("Authenticate")]
        public async Task<ActionResult<LoginOutputDto>> Login([FromBody] LoginInputDto request)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                var result = await loginUseCase.AuthenticateUser(request);

                return Ok(result);

            }
            catch (Exception)
            {

                throw;
            }
        }
    }


}
