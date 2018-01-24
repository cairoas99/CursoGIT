using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormaExer
{
    public class Program
    {
        static void Main(string[] args)
        {
            int opc = 0;
            bool tt;
            double ent;
            do
            {
                Console.Clear();
                Console.WriteLine($"Informe a opção");
                Console.WriteLine($"1-Area do Quadrado");
                Console.WriteLine($"2-Area do Circulo");
                Console.WriteLine($"0-Sair");
                opc = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        Console.WriteLine($"Insira a medida do lado: ");
                        ent = double.Parse(Console.ReadLine());
                        if (ent > 0)
                            tt = true;
                        else
                            tt = false;

                        Quadrado a = new Quadrado(ent);
                        a.Calculo(tt);
                        a.Mostrar();
                        break;
                    case 2:
                        Console.WriteLine($"Insira a medida do raio: ");
                        ent = double.Parse(Console.ReadLine());
                        if (ent > 0)
                            tt = true;
                        else
                            tt = false;

                        Circulo c = new Circulo(ent);
                        Console.WriteLine($"\n");
                        c.Calculo(tt);
                        Console.WriteLine($"\n");
                        c.Mostrar();
                     break;
                }

                Console.ReadKey();

            } while (opc != 0);
        }
    }
}
