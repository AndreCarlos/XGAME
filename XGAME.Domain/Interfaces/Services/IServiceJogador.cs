using XGAME.Domain.Arguments.Jogador;

namespace XGAME.Domain.Interfaces.Services
{
    public interface IServiceJogador
    {
        AutenticarJogadorResponse AutenticarJogador(AutenticarJogadorResquest request);

        AdicionarJogadorResponse AdicionarJogador(AdicionarJogadorRequest request);
    }
}
