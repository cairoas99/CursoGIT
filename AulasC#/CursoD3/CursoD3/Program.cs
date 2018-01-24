using System;

namespace CursoD3
{
    class Program
    {
        static void Main(string[] args)
        {
            int opc = 1;
            
            while(opc != 0)
            {
                Console.Clear();
                Console.WriteLine("Menu");
                Console.WriteLine("1- ");
                Console.WriteLine("0-Sair");
                opc = Convert.ToInt16(Console.ReadLine());
                LPessoa lPessoa = new LPessoa();
                switch (opc)
                {
                    case 1:
                        

                        var pessoa = from p in lPessoa.OrderBy(a => a.Nome) select p;

                        foreach(var item in pessoa)
                        {
                            Console.WriteLine(item.toString());
                        }
                        Console.ReadKey();
                        break;
                }
                Console.ReadKey();
            }
        }
    }
}
