using System;

namespace AppTesteCurso1
{
    class Program
    {
        static void Main(string[] args)
        {
            int opc = 1;
            Console.Write("Escreva seu nome ");
            string nome = Console.ReadLine();
            
            if(String.IsNullOrEmpty(nome))
            {
                Console.WriteLine("Não tem nada aki otario!");
            }
            else
            {
                

                while (opc != 0)
                {
                    Console.Clear();
                    Console.WriteLine("Escolha:  * = Aspas");
                    Console.WriteLine("1-Remove = remove a partir da posição selecionada");
                    Console.WriteLine("2-Rplace = subtitui o que esta antes da virgula pelo que esta depois");
                    Console.WriteLine("3-Substring = le somente o que esta entre as posições passadas");
                    Console.WriteLine("4-ToLower = passa para minusculo");
                    Console.WriteLine("5-ToUpper = passa para maiusculo");
                    Console.WriteLine("6-Split = transforma em array dividindo pelo que é passado");
                    Console.WriteLine("0-Exit");
                    opc = Convert.ToInt16(Console.ReadLine());
                    switch (opc)
                    {
                        case 1:
                            Console.WriteLine("o nome é: " + nome.Remove(5));
                            break;
                        case 2:
                            Console.WriteLine(nome.Replace("Cairo", "oriaC"));
                            break;
                        case 3:
                            Console.WriteLine(nome.Substring(5, 10));
                            break;
                        case 4:
                            Console.WriteLine(nome.ToLower());
                            break;
                        case 5:
                            Console.WriteLine(nome.ToUpper());
                            break;
                        case 6:
                            string[] nomespl = nome.Split(' ');
                            for (int i = 0; i < nomespl.Length; i++)
                            {
                                Console.WriteLine(nomespl[i]);
                            }
                            break;
                    }
                    while (Console.ReadKey().Key != ConsoleKey.Enter) { }
                }

                    
            }
        }
    }
}
