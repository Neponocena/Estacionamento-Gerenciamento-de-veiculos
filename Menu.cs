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

            Console.WriteLine("1 - Cadastrar veiculo");
            Console.WriteLine("2 - Listar veiculos");
            Console.WriteLine("3 - Remover veiculo");
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
                default: Menu.Mostrar();break;
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