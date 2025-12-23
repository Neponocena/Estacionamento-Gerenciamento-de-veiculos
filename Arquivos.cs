using System;
using System.Collections.Generic;
using System.IO;

namespace Estacionamento
{
    public static class Arquivo
    {
        public const string CAMINHO = "dados/veiculos.txt";

        public static List<string> Ler()
        {
            if (!File.Exists(CAMINHO))
                return new List<string>();

            return new List<string>(File.ReadAllLines(CAMINHO));
        }

        public static void Salvar(List<string> lista)
        {
            string pasta = Path.GetDirectoryName(CAMINHO);

            if (!Directory.Exists(pasta))
                Directory.CreateDirectory(pasta);

            File.WriteAllLines(CAMINHO, lista);
        }
    }
}
