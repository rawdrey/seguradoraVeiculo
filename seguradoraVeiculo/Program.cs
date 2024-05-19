using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seguradoraVeiculo
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro();
            Moto moto = new Moto();
            Seguro seguro = new Seguro();
            Console.WriteLine("Digite  os dados do carro:");
            Console.WriteLine(" Marca;");
            carro.Marca = Console.ReadLine();
            Console.WriteLine("Modelo:");
            carro.Modelo = Console.ReadLine();
            Console.WriteLine("Ano:");
            carro.Ano = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor do veículo");
            carro.ValorVeiculo = double.Parse(Console.ReadLine());
            Console.WriteLine("Quantidade de portas:");
            carro.QuantidadePortas = int.Parse
                (Console.ReadLine());
            Console.WriteLine("\nDigite os dados da moto:");
            Console.Write("Marca: ");
            moto.Marca = Console.ReadLine();
            Console.Write("Modelo: ");
            moto.Modelo = Console.ReadLine();
            Console.Write("Ano: ");
            moto.Ano = int.Parse(Console.ReadLine());
            Console.Write("Valor do veículo: ");
            moto.ValorVeiculo = double.Parse(Console.ReadLine());
            Console.Write("Cilindradas: ");
            moto.Cilindradas = int.Parse(Console.ReadLine());
            double seguroCarro = seguro.CalcularSeguro(carro);
            double seguroMoto = seguro.CalcularSeguro(moto);
            Console.WriteLine($"\nSeguro do carro: R${seguroCarro:F2}");
            Console.WriteLine($"Seguro da moto: R${seguroMoto:F2}");
        }
    }
}
