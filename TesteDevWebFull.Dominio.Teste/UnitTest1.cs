using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentValidator;


namespace TesteDevWebFull.Dominio.Teste
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Dado_um_nome_invalido_deve_retornar_uma_notificacao()
        {
            string nome = "An";
            Cargo analistaDeSistemas = new Cargo("Analista de sitemas");
            DateTime dataNascimento = new DateTime(1982,10,10);
            DateTime dataAdmissao = new DateTime(2000, 07, 22);
            DateTime dataDemissao = new DateTime(2003, 11, 18);
            TipoPerfil tecnico = new TipoPerfil("Técnico");
            string identidade = "120702402";
            string cpf = "10196506727";
            string passaporte = "10196506727";
            Pessoa pessoa = new Pessoa(nome, dataNascimento, dataAdmissao, dataDemissao, identidade, cpf, passaporte, analistaDeSistemas, tecnico);
            Assert.IsFalse(pessoa.IsValid());
        }

        [TestMethod]
        public void Dada_uma_DataAdmissao_Menor_que_DataNascimento_deve_retornar_uma_notificacao()
        {
            string nome = "João";
            Cargo analistaDeSistemas = new Cargo("Analista de Sistemas");
            DateTime dataNascimento = new DateTime(1982, 10, 10);
            DateTime dataAdmissao = new DateTime(1980, 07, 22);
            DateTime dataDemissao = new DateTime(2003, 11, 18);
            TipoPerfil tecnico = new TipoPerfil("Técnico");
            string identidade = "120702402";
            string cpf = "10196506727";
            string passaporte = "10196506727";
            Pessoa pessoa = new Pessoa(nome, dataNascimento, dataAdmissao, dataDemissao, identidade, cpf, passaporte, analistaDeSistemas, tecnico);
            Assert.IsFalse(pessoa.IsValid());
        }
        [TestMethod]
        public void Dada_uma_DataDemissao_Menor_que_DataNascimento_deve_retornar_uma_notificacao()
        {
            string nome = "João";
            Cargo analistaDeSistemas = new Cargo("Analista de Sistemas");
            DateTime dataNascimento = new DateTime(1982, 10, 10);
            DateTime dataAdmissao = new DateTime(2000, 07, 22);
            DateTime dataDemissao = new DateTime(1981, 01, 18);
            TipoPerfil tecnico = new TipoPerfil("Técnico");
            string identidade = "120702402";
            string cpf = "10196506727";
            string passaporte = "10196506727";
            Pessoa pessoa = new Pessoa(nome, dataNascimento, dataAdmissao, dataDemissao, identidade, cpf, passaporte, analistaDeSistemas, tecnico);
            Assert.IsFalse(pessoa.IsValid());
        }
        [TestMethod]
        public void Dada_uma_DataDemissao_menor_que_dataAdmissao_deve_retornar_uma_notificacao()
        {
            string nome = "João";
            Cargo analistaDeSistemas = new Cargo("Analista de Sistemas");
            DateTime dataNascimento = new DateTime(1982, 10, 10);
            DateTime dataAdmissao = new DateTime(2000, 07, 22);
            DateTime dataDemissao = new DateTime(2000, 01, 18);
            TipoPerfil tecnico = new TipoPerfil("Técnico");
            string identidade = "120702402";
            string cpf = "10196506727";
            string passaporte = "10196506727";
            Pessoa pessoa = new Pessoa(nome, dataNascimento, dataAdmissao, dataDemissao, identidade, cpf, passaporte, analistaDeSistemas, tecnico);
            Assert.IsFalse(pessoa.IsValid());
        }
        [TestMethod]
        public void Dado_um_cargo_sem_descricao_deve_retornar_uma_notificacao()
        {
            Cargo analistaDeTestes = new Cargo("");
            Assert.IsFalse(analistaDeTestes.IsValid());

        }
    }
}
