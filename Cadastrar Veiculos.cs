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

            Console.Write("Informe o nome do veículo (Digite 0 para sair):");
            string veiculo = Console.ReadLine();
            if(string.IsNullOrWhiteSpace(veiculo))
            {
                Console.WriteLine("O campo não pode ser vazio");
                Console.ReadKey();
                Veiculos();
            }
            
            if(veiculo == "0")
            {
                Menu.Mostrar();
                return;
            }

            Console.Write("Informe a placa do veículo:");
            string placa = Console.ReadLine();
            if(string.IsNullOrWhiteSpace(placa))
            {
                Console.WriteLine("O campo não pode ser vazio");
                Console.ReadKey();
                Veiculos();
            }

            placa = placa.ToUpper();

            veiculos.Add($"{veiculo} - {placa}");
            Arquivo.Salvar(veiculos);
            Log.Registrar($"O veículo {veiculo} com a placa {placa} foi cadastrado com êxito!");



            Console.WriteLine($"O veículo {veiculo} com a placa {placa} foi cadastrado com êxito!");
            Console.ReadKey();
            Menu.Mostrar();

            
        }

        public static void Listar()
        {
            Console.Clear();

            Console.WriteLine("=== LISTA DE VEÍCULOS === (Digite 0 para sair)");
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

            Console.WriteLine("=== VEÍCULOS CADASTRADOS === (Digite 0 para sair):");
            for(int i = 0; i < veiculos.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {veiculos[i]}");
            }


            Console.WriteLine("Digite o número do veículo que deseja remover");
            
            int opcao;
            if(!int.TryParse(Console.ReadLine(),out opcao))
            {
                Console.WriteLine("Digite uma opção valída");
                return;
            }

            if(opcao == 0)
            {
                Menu.Mostrar();
                return;
            }

            string removido = veiculos[opcao - 1];
            veiculos.RemoveAt(opcao - 1);
            Arquivo.Salvar(veiculos);
            Log.Registrar($"{removido} removido");

            Console.WriteLine("Digite a quantidade de horas estacionado:");
            int horas;
            if(!int.TryParse(Console.ReadLine(), out horas))
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
        public static void HistoricoOperacoes()
        {
            Console.Clear();

            Console.WriteLine("=== Historico de operações === (Digite 0 para sair)");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("---------------------------------");
            foreach (var linha in File.ReadAllLines("Dados/log.txt"))
            Console.WriteLine(linha);
            Console.ReadKey();
            Menu.Mostrar();
        }
    }
        
}
