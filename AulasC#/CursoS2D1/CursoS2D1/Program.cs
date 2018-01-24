using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoS2D1
{
    public class Program
    {
        public static void Main(string[] args)
        {

            //Carro c1 = new Carro("Del Rey", "Ford","Bege","FDS-8574",1942);
            Carro c2 = new Carro();

            Console.WriteLine($"Cadastro de carro:");
            Console.WriteLine($"Carro: ");
            c2.Nome = Console.ReadLine();

            Console.WriteLine($"Marca: ");
            c2.Marca = Console.ReadLine();

            Console.WriteLine($"Cor: ");
            c2.Cor = Console.ReadLine();

            Console.WriteLine($"Placa: ");
            c2.Placa = Console.ReadLine();

            Console.WriteLine($"Ano: ");
            c2.Ano = int.Parse(Console.ReadLine());

            
            

            //Console.WriteLine($"Nome do Carro: {c1.Nome}");
            //Console.WriteLine($"Marca: {c1.Marca}");
            //Console.WriteLine($"Cor: {c1.Cor}");
            //Console.WriteLine($"Ano: {c1.Ano}");
            //Console.WriteLine($"Placa: {c1.Placa}");
            //c1.MostraAtributos();

            Console.WriteLine($"\n----------------------------------------------------------------------\n");

            c2.MostraAtributos();

            Console.ReadKey();
        }

    }
}
