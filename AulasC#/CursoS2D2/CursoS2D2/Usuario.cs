using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoS2D2
{
    public class Usuario
    {
        //Atributos
        public int idUsuario { get; set; }
        public string nomeUsuario { get; set; }
        public string sobrenomeUsuario { get; set; }
        public int idadeUsuario { get; set; }


        //construtor
        public Usuario()
        {

        }



        //Metodo
        protected void mostrarDados()
        {
            Console.WriteLine($"Informações");
            Console.WriteLine($"Id: {idUsuario}");
            Console.WriteLine($"Nome: {nomeUsuario}");
            Console.WriteLine($"Sobrenome: {sobrenomeUsuario}");
            Console.WriteLine($"Idade: {idadeUsuario}");

        }


    }
}
