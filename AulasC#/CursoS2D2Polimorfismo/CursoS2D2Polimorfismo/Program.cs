using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoS2D2Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Radio a = new Radio("Mixtrax", "Pioneer", 350.00, "preto", 50);
            a.Ligado(true);
            a.Mostrar();

            Console.WriteLine($"\n_#_#_#_#_#_#_#_#_#_#_#_#_#_#_#_#_#_#_#_#_#_#_\n");

            Televisao t = new Televisao("Num Sei", "LG", 200.00, "Branca", 32);
            t.Ligado(true);
            t.Mostrar();

            Console.ReadKey();




        }
    }
}
