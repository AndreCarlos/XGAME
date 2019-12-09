using XGAME.Domain.Arguments.Jogador;
using XGAME.Domain.Services;
using System;

namespace XGame.AppConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando...");

            var service = new ServiceJogador();

            Console.WriteLine("Criei instância do serviço");

            AutenticarJogadorResquest request = new AutenticarJogadorResquest();
            Console.WriteLine("Criei instancia do meu objeto request");
            request.Email = "Andre";

            var response = service.AutenticarJogador(request);

            Console.ReadKey();
        }
    }
}
