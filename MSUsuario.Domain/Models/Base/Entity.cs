namespace MSUsuario.Domain.Models.Base
{
    public abstract class Entity
    {
        public Guid Id { get; private set; }
        public DateTime DataDoCadastro { get; private set; }
    }
}
