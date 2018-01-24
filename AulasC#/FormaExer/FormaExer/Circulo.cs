using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormaExer
{
    public class Circulo : Forma
    {
        public double AreaC { get; set; }

        public Circulo(double medida) : base(medida)
        {
            AreaC = (Math.PI * (medida * medida));
        }

        public override bool Calculo(bool calc)
        {
            if (calc)
                Console.WriteLine($"Calculo efetuado atraves da formula (PI * (r*r))");
            else
                Console.WriteLine($"Calculo não efetuado");

            return (calc);
        }

        public new virtual void Mostrar()
        {
            Console.WriteLine($"###__ Circulo __###");
            base.Mostrar();
            Console.WriteLine($"Resultado: {AreaC}");
        }
    }
}
