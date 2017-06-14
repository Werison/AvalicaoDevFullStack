using FluentValidator;

namespace TesteDevWebFull.Dominio
{
    public class TipoPerfil: Notifiable
    {
        public string Descricao { get; private set; }

        public TipoPerfil(string descricao)
        {
            Descricao = descricao;
            new ValidationContract<TipoPerfil>(this).IsRequired(x => x.Descricao, "O campo descrição do cargo deve ser preenchido");
        }
    }
}