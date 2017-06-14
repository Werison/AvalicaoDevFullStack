using FluentValidator;

namespace TesteDevWebFull.Dominio
{
    public class Cargo: Notifiable
    {
        public string Nome { get; private set; }

        public Cargo(string nome)
        {
            Nome = nome;
            new ValidationContract<Cargo>(this).IsRequired(x => x.Nome, "O campo nome do cargo deve ser preenchido");
        }
    }
}