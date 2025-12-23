using System;
using System.Collections.Generic;

namespace Estacionamento
{
    public static class Cadastrar
    {
        private static List<string> veiculos = Arquivo.Ler();

        public static void Veiculos()
        {
            Console.Clear();

            Console.Write("Informe o nome do veículo:");
            string veiculo = Console.ReadLine();
            if(string.IsNullOrWhiteSpace(veiculo))
            {
                Console.WriteLine("O campo não pode ser vazio");
                Console.ReadKey();
                Veiculos();
            }

            Console.Write("Informe a placa do veículo:");
            string placa = Console.ReadLine();
            if(string.IsNullOrWhiteSpace(placa))
            {
                Console.WriteLine("O campo não pode ser vazio");
                Console.ReadKey();
                Veiculos();
            }

            veiculos.Add($"{veiculo} - {placa}");
            Arquivo.Salvar(veiculos);

            Console.WriteLine($"O veículo {veiculo} com a placa {placa} foi cadastrado com êxito!");
            Console.ReadKey();
            Menu.Mostrar();
        }

        public static void Listar()
        {
            Console.Clear();

            Console.WriteLine("=== LISTA DE VEÍCULOS ===");
            Console.WriteLine("----------------------------");

            if (veiculos.Count == 0)
            {
                Console.WriteLine("Nenhum veículo cadastrado.");
            }
            else
            {
                foreach (var item in veiculos)
                {
                    Console.WriteLine(item);
                }
            }

            Console.ReadKey();
            Menu.Mostrar();
        }

        public static void Remover()
        {
            Console.Clear();

            if(veiculos.Count == 0)
            {
                Console.WriteLine("Nenhum veiculo para remover.");
                Console.ReadKey();
                Menu.Mostrar();
            }

            Console.WriteLine("=== VEÍCULOS CADASTRO ===");
            for(int i = 0; i < veiculos.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {veiculos[i]}");
            }

            Console.WriteLine("Digite o número do veículo que deseja remover");
            if(!int.TryParse(Console.ReadLine(),out int opcao) || opcao < 1 || opcao > veiculos.Count)
            {
                Console.WriteLine("Opção inválida.");
                Console.ReadKey();
                Veiculos();
            }

            string removido = veiculos[opcao - 1];
            veiculos.RemoveAt(opcao - 1);
            Arquivo.Salvar(veiculos);

            Console.WriteLine("Digite a quantidade de horas estacionado:");
            int horas;
            if(int.TryParse(Console.ReadLine(), out horas))
            {
                Console.WriteLine("Digite um número valído");
                Console.ReadKey();
                return;
            }

            

            Console.WriteLine($"{removido} removido");
            Console.WriteLine($"Valor total: R${horas * 5}");

            Console.ReadKey();
            Menu.Mostrar();
        }
    }
}
