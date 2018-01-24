using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoS2D2Polimorfismo
{
    public abstract class Eletronico
    {
        public string Nome { get; set; }
        public string Marca { get; set; }
        public double Preco { get; set; }
        public string Cor { get; set; }

        public Eletronico(string nome, string marca, double preco, string cor)
        {
            Nome = nome;
            Marca = marca;
            Preco = preco;
            Cor = cor;

        }

        protected void Mostrar()
        {
            Console.WriteLine($"##_ INFORMAÇÕES _##");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Preço: {Preco}");
            Console.WriteLine($"Cor: {Cor}");
        }


        public abstract bool Ligado(bool valor);
    }
}
