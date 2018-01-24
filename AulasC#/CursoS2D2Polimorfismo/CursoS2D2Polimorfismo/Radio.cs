using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoS2D2Polimorfismo
{
    public class Radio:Eletronico
    {
        public int Potencia { get; set; }

        public Radio(string nome, string marca, double preco, string cor, int potencia)
            :base(nome, marca, preco, cor)
        {
            Potencia = potencia;
        }

        public override bool Ligado( bool valor)
        {
            if (valor)
                Console.WriteLine($"Radio ligado pelo botão");
            else
                Console.WriteLine($"Radio desligado");

            return (valor);

        }

        public new virtual void Mostrar()
        {
            Console.WriteLine($"__# RADIO #__");
            base.Mostrar();
            Console.WriteLine($"Potencia: {Potencia}");
        }
    }
}
