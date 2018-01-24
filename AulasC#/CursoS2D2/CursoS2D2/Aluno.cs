using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoS2D2
{
    public class Aluno:Usuario
    {
        public double notaAluno { get; set; }


        public virtual void mostraDados()
        {
            Console.WriteLine($"##_ Aluno: _##");
            base.mostrarDados();
            Console.WriteLine($"Nota: {notaAluno}");
        }

        public Aluno(int id, string nome, string sobrenome, int idade, double nota)
        {
            idUsuario = idade;
            nomeUsuario = nome;
            sobrenomeUsuario = sobrenome;
            idadeUsuario = idade;
            this.notaAluno = nota;

        }

    }
}
