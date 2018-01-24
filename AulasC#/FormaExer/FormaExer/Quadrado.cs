using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormaExer
{
    public class Quadrado : Forma
    {
        public double Resultado { get; set; }

        public Quadrado(double medida) : base(medida)
        {
            Resultado = medida * medida;
        }
        
        public override bool Calculo(bool calc)
        {
            if (calc)
                Console.WriteLine($"Calculo efetuado atraves da formula (L*L)");
            else
                Console.WriteLine($"Calculo não efetuado");

            return (calc);
        }

        public new virtual void Mostrar()
        {
            Console.WriteLine($"###__ Quadrado __###");
            base.Mostrar();
            Console.WriteLine($"Resultado: {Resultado}");
        }
    }
}
