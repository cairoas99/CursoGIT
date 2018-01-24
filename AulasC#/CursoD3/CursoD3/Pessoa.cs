using System;
using System.Collections.Generic;
using System.Text;

namespace CursoD3
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Cidade { get; set; }
        public string Sexo { get; set; }

        public Pessoa(string nome, int idade, string cidade, string sexo)
        {
            Nome = nome;
            Idade = idade;
            Cidade = cidade;
            Sexo = sexo;
        }

        public override string ToString()
        {
            return "Nome: " + Nome + "Idade: " + Idade + "Cidade: " + Cidade + "Sexo: " + Sexo;
        }
    }
    class LPessoa : List<Pessoa>
    {
        public LPessoa()
        {
            this.Add(new Pessoa("Cairo", 21, "Franca", "M"));
            this.Add(new Pessoa("JOSÉ DA SILVA", 21, "PIRACICABA", "M"));
            this.Add(new Pessoa("ADRIANA GOMES",18 , "CURITIBA", "F"));
            this.Add(new Pessoa("JOSELINO SOUZA", 25, "IBIRACI", "M"));
            this.Add(new Pessoa("ELENA ROSA", 50, "FERNANDOPOLIS", "F"));
            this.Add(new Pessoa("MARIA APARECIDA", 54, "CLARAVAL", "F"));
            this.Add(new Pessoa("MARIANA NEVES", 17, "FRANCA", "F"));
            this.Add(new Pessoa("ANDRE NEVES", 50, "CAMPINAS", "M"));
            this.Add(new Pessoa("PABLO VITTAR", 24, "ROLANDIA", "F"));
            this.Add(new Pessoa("JOSEFINO DANTAS", 48, "CAMPOS DO JORDAO", "M"));
            this.Add(new Pessoa("BRUNO MARTINO", 55, "AMERICANA", "M"));
            this.Add(new Pessoa("ISABELA MENDES", 32, "PIRACICABA", "F"));
            this.Add(new Pessoa("ANA MARIA GONÇALVES", 60, "PRAIA GRANDE", "F"));
            this.Add(new Pessoa("ISADORA PINTO", 30, "SÃO PAULO", "F"));
        }
    }
}
