using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoS2D2
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a = new Aluno(1, "Isadora", "Pula", 18, 8.7);

            a.mostraDados();

            Console.WriteLine($"\n----------------------------------------\n");

            Professor p = new Professor(2, "Josesvaldo","Silva", 58, 14758.58);

            p.mostrarDados();


            Console.ReadKey();


        }
    }
}
