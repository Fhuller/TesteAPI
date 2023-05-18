using TesteAPI.Entities;

namespace TesteAPI.Repository
{
    public class FuncionarioRepository
    {

        public Funcionario DefinitivamenteUmaQueryList(Request request)
        {
            Funcionario funcionario = new Funcionario(new Guid(), "Feiuco", DateTime.Now);

            return funcionario;
        }

    }
}
