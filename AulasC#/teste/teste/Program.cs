using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste
{
    class Program
    {
        static void Main(string[] args)
        {
            int opc = 1;
            

            while (opc != 0)
            {
                Console.Clear();
                Console.WriteLine("Menu");
                Console.WriteLine("1- ");
                Console.WriteLine("2- ");
                Console.WriteLine("3- ");
                Console.WriteLine("4- Palavra");
                Console.WriteLine("5- Media");
                Console.WriteLine("0-Sair");
                opc = Convert.ToInt16(Console.ReadLine());
                LPessoa lPessoa = new LPessoa();
                switch (opc)
                {
                    case 1:
                        var pessoa = from p in lPessoa.OrderBy(a => a.Nome) select p;

                        foreach (var item in pessoa)
                        {
                            Console.WriteLine(item.ToString());
                        }
                        Console.ReadKey();
                        break;
                    case 2:
                        var pessoa2 = from p in lPessoa.Where(p => p.Idade >= 20 && p.Idade <= 30) select p;
                        foreach (var item in pessoa2)
                        {
                            Console.WriteLine(item.ToString());
                        }
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("Insira o nome a ser procurado:");
                        string procura = Console.ReadLine();
                        foreach (var item in lPessoa.Where(p => p.Nome.StartsWith(procura)))
                        {
                            Console.WriteLine(item.ToString());
                        }
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.WriteLine("Insira a palavra");
                        string pala = Console.ReadLine();
                        string aocp = "";

                        for (int i = (pala.Length - 1); i >= 0; i--)
                        {
                            aocp += pala[i];
                        }
                        Console.WriteLine($"ao contrario: {aocp}");
                        if (aocp == pala)
                            Console.WriteLine("Palavras iguais");
                        else
                            Console.WriteLine("Palavras diferentes");

                        Console.ReadKey();
                        break;
                    case 5:
                        Console.WriteLine("Insira as notas separadas por espaço");
                        string[] notas = Console.ReadLine().Split(' ');
                        double soma = 0, media = 0;

                        for(int i = 0; i < notas.Length; i++)
                        {
                            soma += Convert.ToDouble(notas[i]);
                        }
                        media = Math.Round(soma / notas.Length, 2);
                        Console.WriteLine($"Media: {media}");


                        Console.ReadKey();
                        break;
                    
                }
                
            }
        }
    }
}
