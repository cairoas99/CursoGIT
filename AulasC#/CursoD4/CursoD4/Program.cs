using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoD4
{
    class Program
    {
        static void Main(string[] args)
        {
            int opc = 1;
            
            while (opc != 0)
            {
                decimal num, n1, n2, n3;

                Console.Clear();

                Console.WriteLine($"Menu");
                Console.WriteLine($"1-Soma");
                Console.WriteLine($"2-Subt");
                Console.WriteLine($"3-Divi");
                Console.WriteLine($"4-Mult");
                Console.WriteLine($"5-Tabu");
                Console.WriteLine($"6-Soma 3");
                Console.WriteLine($"0-Sair");
                Console.WriteLine($"Digite a opção escolhida:");
                opc = int.Parse(Console.ReadLine());


                switch (opc)
                {
                    case 1:
                        Console.WriteLine($"Insira um numero");
                        n1 = decimal.Parse(Console.ReadLine());

                        Console.WriteLine($"Insira outro numero");
                        n2 = decimal.Parse(Console.ReadLine());
                        num = Soma(n1, n2);
                        Console.WriteLine($"Resultado: {num}");
                        break;
                    case 2:
                        Console.WriteLine($"Insira um numero");
                        n1 = decimal.Parse(Console.ReadLine());

                        Console.WriteLine($"Insira outro numero");
                        n2 = decimal.Parse(Console.ReadLine());
                        num = Subt(n1, n2);
                        Console.WriteLine($"Resultado: {num}");
                        break;
                    case 3:
                        Console.WriteLine($"Insira um numero");
                        n1 = decimal.Parse(Console.ReadLine());

                        Console.WriteLine($"Insira outro numero");
                        n2 = decimal.Parse(Console.ReadLine());
                        num = Divi(n1, n2);
                        Console.WriteLine($"Resultado: {num}");
                        break;
                    case 4:
                        Console.WriteLine($"Insira um numero");
                        n1 = decimal.Parse(Console.ReadLine());

                        Console.WriteLine($"Insira outro numero");
                        n2 = decimal.Parse(Console.ReadLine());
                        num = Multi(n1, n2);
                        Console.WriteLine($"Resultado: {num}");
                        break;
                    case 5:
                        Console.WriteLine($"Insira o numero");
                        n1 = decimal.Parse(Console.ReadLine());
                        Tabu(n1);
                        break;
                    case 6:
                        Console.WriteLine($"Insira um numero");
                        n1 = decimal.Parse(Console.ReadLine());

                        Console.WriteLine($"Insira outro numero");
                        n2 = decimal.Parse(Console.ReadLine());

                        Console.WriteLine($"Insira um numero");
                        n3 = decimal.Parse(Console.ReadLine());

                        num = Soma(n1, n2, n3);
                        Console.WriteLine($"Resultado: {num}");
                        break;
                    default:
                        Console.WriteLine($"Algo de errado não esta certo");
                        break;
                }
                

                Console.ReadKey();
            }


        }

        public static decimal Soma(decimal num1, decimal num2)
        {
            decimal soma = num1 + num2;
            return soma;
        }
        public static decimal Soma(decimal num1, decimal num2, decimal num3)
        {
            decimal soma = num1 + num2 + num3;
            return soma;
        }
        public static decimal Subt(decimal num1, decimal num2)
        {
            decimal subt = num1 - num2;
            return subt;
        }
        public static decimal Multi(decimal num1, decimal num2)
        {
            decimal multi = num1 * num2;
            return multi;
        }
        public static decimal Divi(decimal num1, decimal num2)
        {
            decimal divi =  num1/num2;
            return divi;
        }
        public static void Tabu(decimal num)
        {
            for(int x = 0; x <= 10; x++)
            {
                Console.WriteLine(num + "x" + x + "=" + (x * num));
            }
            Console.ReadKey();
        }

    }
}