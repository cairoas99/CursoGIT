using System;

namespace CursoD2
{
    class Program
    {
        static void Main(string[] args)
        {
            int opc = 1;
            while (opc != 0) {
                Console.Clear();
                Console.WriteLine("Menu");
                Console.WriteLine("1-For");
                Console.WriteLine("2-while");
                Console.WriteLine("3-switch case(ta rodando)");
                Console.WriteLine("4-foreach");
                Console.WriteLine("5-Ex soma ate 100 - mult 3");
                Console.WriteLine("6-Ex ana");
                Console.WriteLine("7-IMC");
                Console.WriteLine("8-Media");
                Console.WriteLine("0-Sair");
                Console.WriteLine("escolha:");
                opc = Convert.ToInt16(Console.ReadLine());
                switch (opc) {
                    case 1:
                        for (int a = 1; a < 4; a++)
                        {
                            Console.WriteLine($"Escreva o {a}º Nome");
                            Console.ReadLine();
                        }
                        break;
                    case 2:
                        int num = 0, nt = 0;
                        Console.WriteLine("insira um numero maior q 0");
                        num = Convert.ToInt16(Console.ReadLine());
                        while (num >= nt) {
                            Console.WriteLine(nt);
                            nt++;
                        }

                        break;
                    case 4:
                        string[] lista = { "Cairo", "Araujo", "Santos" };
                        foreach(var nome in lista)
                        {
                            Console.WriteLine(nome);
                        }
                        break;
                    case 5:
                        int soma = 0;
                        for(int i = 1; i <= 100; i++)
                        {
                            if(i % 3 != 0)
                            {
                                soma += i;
                            }
                        }
                        Console.WriteLine("total: "+soma);
                        break;
                    case 6:
                        int qt = 0;
                        string ana = "ana e mariana gostam de banana";
                        Console.WriteLine(ana);
                        //string[] spl = ana.Split(' ');
                        for(var i = 1; i < ana.Length; i++)
                        {
                            if (ana[i] == 'n'&& ana[i+1] == 'a' && ana[i-1] == 'a')
                            {
                                qt++;
                            }
                        }
                        Console.WriteLine($"Quantidades de palavra ana na frase: {qt}");
                        break;
                    case 7:
                        Console.WriteLine("Informe o peso(use ,):");
                        double peso = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Informe a altura(use ,):");
                        double altura = Convert.ToDouble(Console.ReadLine());
                        double imc = (peso / (altura * altura));
                        Console.WriteLine($"Seu IMC é: {Math.Round(imc,2)}");
                        if (imc <= 18.5)
                            Console.WriteLine("Abaixo do peso");
                        else if(imc > 18.5 && imc < 25)
                            Console.WriteLine("Peso ideal");
                        else if(imc >= 25 && imc < 30)
                            Console.WriteLine("Levemente acima do peso");
                        else if(imc >= 30 && imc < 35)
                            Console.WriteLine("Obesidade grau 1");
                        else if(imc >= 35 && imc < 40)
                            Console.WriteLine("Obesidade grau 2");
                        else
                            Console.WriteLine("Obesidade morbida");
                        break;
                    case 8:
                        decimal notas = 0, med = 0;
                        for(int m = 1; m < 5; m++)
                        {
                            Console.WriteLine($"Indira a {m}ª nota:");
                            notas += Convert.ToDecimal(Console.ReadLine());
                        }
                        med = notas / 4;
                        Console.WriteLine($"Media: {med}");
                        break;

                }
                Console.ReadKey();
            
            }
        }
    }
}
