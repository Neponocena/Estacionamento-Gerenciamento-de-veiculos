using System;
namespace Estacionamento
{
    
    
        public static class Menu
    {
        public static void Mostrar()
        {
            try{
            Console.Clear();

            Console.WriteLine(@"

███████╗░██████╗████████╗░█████╗░░█████╗░██╗░█████╗░███╗░░██╗░█████╗░███╗░░░███╗███████╗███╗░░██╗████████╗░█████╗░
██╔════╝██╔════╝╚══██╔══╝██╔══██╗██╔══██╗██║██╔══██╗████╗░██║██╔══██╗████╗░████║██╔════╝████╗░██║╚══██╔══╝██╔══██╗
█████╗░░╚█████╗░░░░██║░░░███████║██║░░╚═╝██║██║░░██║██╔██╗██║███████║██╔████╔██║█████╗░░██╔██╗██║░░░██║░░░██║░░██║
██╔══╝░░░╚═══██╗░░░██║░░░██╔══██║██║░░██╗██║██║░░██║██║╚████║██╔══██║██║╚██╔╝██║██╔══╝░░██║╚████║░░░██║░░░██║░░██║
███████╗██████╔╝░░░██║░░░██║░░██║╚█████╔╝██║╚█████╔╝██║░╚███║██║░░██║██║░╚═╝░██║███████╗██║░╚███║░░░██║░░░╚█████╔╝
╚══════╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░╚═╝░╚════╝░╚═╝░░╚══╝╚═╝░░╚═╝╚═╝░░░░░╚═╝╚══════╝╚═╝░░╚══╝░░░╚═╝░░░░╚════╝░");
Console.WriteLine("----------------------------------------------------------------------------------------");
            Console.WriteLine(@"


█▀▀ █▀▀ █▀█ █▀▀ █▄░█ █▀▀ █ ▄▀█ █▀▄▀█ █▀▀ █▄░█ ▀█▀ █▀█   █▀▄ █▀▀   █░█ █▀▀ █ █▀▀ █░█ █░░ █▀█ █▀
█▄█ ██▄ █▀▄ ██▄ █░▀█ █▄▄ █ █▀█ █░▀░█ ██▄ █░▀█ ░█░ █▄█   █▄▀ ██▄   ▀▄▀ ██▄ █ █▄▄ █▄█ █▄▄ █▄█ ▄█");

Console.WriteLine("----------------------------------------------------------------------------------------------------------");
            Console.WriteLine("");

            Console.WriteLine("1 - CADASTRAR VEÍCULOS");
            Console.WriteLine();
            Console.WriteLine("2 - LISTAR VEÍCULOS");
            Console.WriteLine();
            Console.WriteLine("3 - REMOVER VEÍCULO");
            Console.WriteLine();
            Console.WriteLine("4 - HISTORICO DE OPERAÇÕES");
            Console.WriteLine();
            Console.WriteLine("0 - FECHAR APLICAÇÃO");
            Console.WriteLine("---------------------");
            
            int opcao;
            if(!int.TryParse(Console.ReadLine(),out opcao))
                {
                    Console.WriteLine("Digite uma opção valída");
                    Console.ReadKey();
                    Mostrar();
                    return;
                }

            switch(opcao)
            {
                case 1: Cadastrar.Veiculos();break;
                case 2: Cadastrar.Listar();break;
                case 3: Cadastrar.Remover();break;
                case 4: Cadastrar.HistoricoOperacoes();break;
                default: System.Environment.Exit(0);break;
            }
            }
            catch
            {
                Console.WriteLine("Digite uma opção valida");
                Console.ReadKey();
                Mostrar();
            }
        }

    }
    
}