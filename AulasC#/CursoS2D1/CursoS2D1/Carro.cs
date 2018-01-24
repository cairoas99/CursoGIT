using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoS2D1
{
    public class Carro
    {
        public string Nome { get; set; }
        public string Marca { get; set; }
        public string Cor { get; set; }
        public string Placa { get; set; }
        public int Ano { get; set; }

        public Carro(string nome, string marca, string cor, string placa, int ano)
        {
            Nome = nome;
            Marca = marca;
            Cor = cor;
            Placa = placa;
            Ano = ano;
        }
        public Carro()
        {

        }

        public void Andar()
        {
            Console.WriteLine($"Andando... Vruum!");
        }

        public bool Ligado(bool valor)
        {
            if (valor)
                Console.WriteLine($"Carro Ligado");
            else
                Console.WriteLine($"Carro desligado");

            return (valor);
        }

        public bool Combustao(bool valor)
        {
            if (valor)
                Console.WriteLine($"Fazendo combustão");
            else
                Console.WriteLine($"Não fazendo combustão");

            return (valor);

        }
        public void MostraAtributos()
        {
            Console.WriteLine($"CARRO:");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Cor: {Cor}");
            Console.WriteLine($"Ano: {Ano}");
            Console.WriteLine($"Placa: {Placa}");
        }



    }
}
