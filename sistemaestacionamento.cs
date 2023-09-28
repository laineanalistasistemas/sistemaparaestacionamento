using System;
using System.Collections.Generic;

namespace Estacionamento
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criar uma lista para armazenar os carros estacionados
            List<Carro> carrosEstacionados = new List<Carro>();

            while (true)
            {
                Console.WriteLine("Bem-vindo ao estacionamento!");
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1 - Estacionar carro");
                Console.WriteLine("2 - Retirar carro");
                Console.WriteLine("3 - Mostrar carros estacionados");
                Console.WriteLine("4 - Sair");

                // Ler a opção escolhida pelo usuário
                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        // Estacionar carro
                        Console.WriteLine("Digite a placa do carro:");
                        string placa = Console.ReadLine();

                        Console.WriteLine("Digite o modelo do carro:");
                        string modelo = Console.ReadLine();

                        Carro carro = new Carro(placa, modelo);
                        carrosEstacionados.Add(carro);

                        Console.WriteLine("Carro estacionado com sucesso!");
                        break;

                    case 2:
                        // Retirar carro
                        Console.WriteLine("Digite a placa do carro que deseja retirar:");
                        string placaRetirada = Console.ReadLine();

                        // Procurar o carro na lista pelo número da placa
                        foreach (Carro c in carrosEstacionados)
                        {
                            if (c.Placa == placaRetirada)
                            {
                                carrosEstacionados.Remove(c);
                                Console.WriteLine("Carro retirado com sucesso!");
                                break;
                            }
                        }
                        break;

                    case 3:
                        // Mostrar carros estacionados
                        Console.WriteLine("Carros estacionados:");

                        foreach (Carro c in carrosEstacionados)
                        {
                            Console.WriteLine("Placa: " + c.Placa + ", Modelo: " + c.Modelo);
                        }
                        break;

                    case 4:
                        // Sair do programa
                        return;

                    default:
                        Console.WriteLine("Opção inválida! Tente novamente.");
                        break;
                }
            }
        }
    }

    class Carro
    {
        public string Placa { get; set; }
        public string Modelo { get; set; }

        public Carro(string placa, string modelo)
        {
            Placa = placa;
            Modelo = modelo;
        }
    }
}
