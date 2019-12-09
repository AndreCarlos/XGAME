using System;
using XGAME.Domain.Interfaces.Arguments;

namespace XGAME.Domain.Arguments.Jogador
{
    public class AdicionarJogadorResponse : IResponse

    {
        public Guid Id { get; set; }

        public string Message { get; set; }
    }
}
