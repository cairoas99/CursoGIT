using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormaExer
{
    public abstract class Forma
    {
        public double Medida { get; set; }

        public Forma(double medida)
        {
            Medida = medida;
        }

        protected void Mostrar()
        {
            Console.WriteLine($"Medida informada {Medida}");
        }

        public abstract bool Calculo(bool calc);
    }
}
