using System;

namespace seguradoraVeiculo
{
    class Program
    {
        static void Main(string[] args)
        {
            Seguro seguro = new Seguro();

            Console.WriteLine("Escolha o tipo de veículo para fazer o seguro:");
            Console.WriteLine("1 - Carro");
            Console.WriteLine("2 - Moto");
            Console.Write("Escolha: ");
            int escolha = int.Parse(Console.ReadLine());

            if (escolha == 1)
            {
                Console.WriteLine("\nDigite os dados do carro:");
                Console.Write("Placa (até 7 caracteres): ");
                string placa = Console.ReadLine().Substring(0, Math.Min(7, Console.ReadLine().Length));
                Carro carro = new Carro(placa);
                Console.Write("Marca: ");
                carro.Marca = Console.ReadLine();
                Console.Write("Modelo: ");
                carro.Modelo = Console.ReadLine();
                Console.Write("Ano: ");
                carro.Ano = int.Parse(Console.ReadLine());
                Console.Write("Valor do veículo: ");
                carro.ValorVeiculo = double.Parse(Console.ReadLine());
                Console.Write("Quantidade de portas: ");
                carro.QuantidadePortas = int.Parse(Console.ReadLine());

                double seguroCarro = seguro.CalcularSeguro(carro);
                Console.WriteLine($"\nSeguro do carro placa {carro.Placa}: R${seguroCarro:F2}");
            }
            else if (escolha == 2)
            {
                Console.WriteLine("\nDigite os dados da moto:");
                Console.Write("Placa (até 7 caracteres): ");
                string placa = Console.ReadLine().Substring(0, Math.Min(7, Console.ReadLine().Length));
                Moto moto = new Moto(placa);
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

                double seguroMoto = seguro.CalcularSeguro(moto);
                Console.WriteLine($"\nSeguro da moto placa {moto.Placa}: R${seguroMoto:F2}");
            }
            else
            {
                Console.WriteLine("Opção inválida.");
            }
        }
    }