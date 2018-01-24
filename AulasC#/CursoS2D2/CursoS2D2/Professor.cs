using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoS2D2
{
    public class Professor:Usuario
    {
        public double salarioProfrssor { get; set; }

        public new virtual void mostrarDados()
        {
            Console.WriteLine($"##_ Professor: _##");
            base.mostrarDados();
            Console.WriteLine($"Salario {salarioProfrssor}");
        }

        public Professor(int id, string nome, string sobrenome, int idade, double salario)
        {
            idUsuario = id;
            nomeUsuario = nome;
            sobrenomeUsuario = sobrenome;
            idadeUsuario = idade;
            salarioProfrssor = salario;

        }
    }
}
