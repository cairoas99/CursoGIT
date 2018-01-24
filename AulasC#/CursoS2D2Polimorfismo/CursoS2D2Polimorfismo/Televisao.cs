using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoS2D2Polimorfismo
{
    public class Televisao:Eletronico
    {
        public int Polegadas { get; set; }



        public Televisao(string nome, string marca, double preco, string cor, int polegadas)
            : base(nome, marca, preco, cor)
        {
            Polegadas = polegadas;
        }
        

        public override bool Ligado(bool valor)
        {
            if (valor)
                Console.WriteLine($"TV ligada pelo controle");
            else
                Console.WriteLine($"TV desligada");

            return (valor);

        }

        public new virtual void Mostrar()
        {
            Console.WriteLine($"__# TV #__");
            base.Mostrar();
            Console.WriteLine($"Polegadas: {Polegadas}");
        }

    }
}
