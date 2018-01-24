using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoD5
{
    class Program
    {
        static void Main(string[] args)
        {
            int opc;
            do
            {
                Console.Clear();
                Console.WriteLine("Menu");
                Console.WriteLine("EXER 1");
                Console.WriteLine("EXER 2");
                Console.WriteLine("EXER 3");
                Console.WriteLine("EXER 4");
                Console.WriteLine("EXER 5");
                Console.WriteLine("EXER 6");
                Console.WriteLine("EXER 7");
                Console.WriteLine("EXER 8");
                Console.WriteLine("SAIR 0");
                Console.WriteLine("Insira a opção: ");
                opc = int.Parse(Console.ReadLine());

                //var:
                string pala, frase, nome, sexo;
                int num, idade;
                int[] vet = new int[3];
                int[] vet2 = new int[5];
                int[] vet3 = new int[5];
                double[] notas = new double[4];
                double media;
                Random random = new Random();

                switch (opc)
                {
                    case 1:
                        Console.WriteLine("Insira a palavra: ");
                        pala = Console.ReadLine();
                        for(int i = 0; i < pala.Length; i++)
                        {
                            Console.WriteLine(pala[i]);
                        }
                        break;
                    case 2:
                        Console.WriteLine("Insira uma palavra: ");
                        pala = Console.ReadLine();
                        Console.WriteLine("Insira uma uma frase:");
                        frase = Console.ReadLine();

                        if (frase.Contains(pala))
                            Console.WriteLine("A palavra existe na frase");
                        else
                            Console.WriteLine("A palavra não existe na frase");
                        break;

                    case 3:
                        Console.WriteLine("Insira um numero inteiro:");
                        num = int.Parse(Console.ReadLine());

                        if ((num % 2) == 0)
                            Console.WriteLine("É par");
                        else
                            Console.WriteLine("Não é");
                        break;
                    case 4:
                        for (int i = 0; i < 3; i++)
                        {
                            Console.WriteLine($"Insira o número: {i + 1}:");
                            vet[i] = int.Parse(Console.ReadLine());
                        }
                        for (int i = 0; i < 3; i++)
                        {
                            Console.WriteLine($"O número {i + 1} é {vet[i]}");
                        }
                        break;
                    case 5:
                        Console.WriteLine("Nome:");
                        nome = Console.ReadLine();

                        Console.WriteLine("Idade:");
                        idade = int.Parse(Console.ReadLine());

                        Console.WriteLine("Sexo:M/F");
                        sexo = Console.ReadLine().ToUpper();

                        if (idade >= 18 && sexo == "M")
                            Console.WriteLine("É maior de idade do sexo masculino");
                        else
                            Console.WriteLine("Não é maior de idade do sexo masculino");

                        break;

                    case 6:
                        for (int i = 0; i < 4; i++)
                        {
                            Console.WriteLine($"Insira a nota {i+1}: ");
                            notas[i] = double.Parse(Console.ReadLine());
                        }
                        media = ((notas.Sum()) / notas.Length);

                        if (media >= 7)
                            Console.WriteLine("A media da turma é maior ou igual a 7");
                        else
                            Console.WriteLine("A media da turma é menor do que 7");

                        break;

                    case 7:
                        for(int i = 0; i < 3; i++)
                        {
                            Console.WriteLine("Insira um numero: ");
                            vet[i] = int.Parse(Console.ReadLine());
                        }
                        Console.WriteLine($"Maior: {vet.Max()}");
                        break;
                    case 8:
                        //Console.WriteLine("Insira um numero");
                        //int a = int.Parse(Console.ReadLine());

                        //Console.WriteLine("Insira um numero");
                        //int b = int.Parse(Console.ReadLine());

                        for (int i = 0; i < 5; i++)
                        {
                            vet2[i] = random.Next(1, 100);
                            Console.WriteLine(vet2[i]);
                        }
                        vet3 = vet2.OrderBy(x => x).ToArray();
                        Console.WriteLine($"-----------------------------------");
                        for (int i = 0; i < 5; i++)
                        {
                            Console.WriteLine(vet3[i]);
                        }
                        break;

                }
                Console.WriteLine("");
                Console.ReadKey();
            }
            while (opc != 0);
        }

    }
}
