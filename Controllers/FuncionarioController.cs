using Microsoft.AspNetCore.Mvc;
using TesteAPI.Entities;
using TesteAPI.Repository;

namespace TesteAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FuncionarioController : ControllerBase
    {
        [HttpGet(Name = "FuncionarioList")]
        public Funcionario List(Request request)
        {
            FuncionarioRepository code = new FuncionarioRepository();

            return code.DefinitivamenteUmaQueryList(request);
        }
    }
}
