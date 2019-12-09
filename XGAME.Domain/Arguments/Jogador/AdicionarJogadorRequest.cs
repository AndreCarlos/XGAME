using XGAME.Domain.Interfaces.Arguments;
using XGAME.Domain.ValueObjects;

namespace XGAME.Domain.Arguments.Jogador
{
    public class AdicionarJogadorRequest : IRequest
    {
        public Nome Nome { get; set; }

        public Email Email { get; set; }

        public string Senha { get; private set; }
    }
}
