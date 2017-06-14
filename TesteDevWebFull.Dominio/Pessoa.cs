using System;
using FluentValidator;

namespace TesteDevWebFull.Dominio
{
    public class Pessoa : Notifiable
    {
        public string Nome { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public DateTime DataAdmissao { get; private set; }
        public DateTime DataDemissao { get; private set; }
        public string Identidade { get; private set; }
        public string Cpf { get; private set; }
        public string Passaporte { get; private set; }
        public Cargo Cargo { get; private set; }
        public TipoPerfil TipoPerfil { get; private set; }


        public Pessoa(string nome, DateTime dataNascimento, DateTime dataAdmissao, DateTime dataDemissao, string identidade, string cpf, string passaporte, Cargo cargo, TipoPerfil tipoPerfil)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
            DataAdmissao = dataAdmissao;
            DataDemissao = dataDemissao;
            Identidade = identidade;
            Cpf = cpf;
            Cargo = cargo;
            TipoPerfil = tipoPerfil;

            //validacoes
            new ValidationContract<Pessoa>(this)
                .IsRequired(x => x.Nome, "O Campo nome deve ser preenchido.")
                .HasMinLenght(x => x.Nome, 3, "O campo nome deve possuir mais do que três caracteres.")
                .IsLowerThan(x => x.DataNascimento, dataAdmissao, "A data de nascimento deve ser menor que a data de admissão.")
                .IsLowerThan(x => x.DataNascimento, DataDemissao, "A data de nascimento deve ser menor que a data de demissão.")
                .IsLowerThan(x => x.DataAdmissao, DataDemissao, "A data de admissão deve ser menor que a data de demissão.");
            AddNotifications(cargo.Notifications);
            AddNotifications(tipoPerfil.Notifications);


        }
    }
}