namespace TesteAPI.Entities
{
    public class Funcionario
    {

        private Guid _id;
        private string _nome;
        private DateTime _date;

        public Funcionario(Guid id, string nome, DateTime date)
        {
            _id = id;
            _nome = nome;
            _date = date;
        }

    }
}
