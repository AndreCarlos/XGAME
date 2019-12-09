using System;
using XGAME.Domain.Arguments.Jogador;

namespace XGAME.Domain.Interfaces.Repositories
{
    public interface IRepositoryJogador
    {
        AutenticarJogadorResponse AutenticarJogador(AutenticarJogadorResquest request);

        Guid AdicionarJogador(AdicionarJogadorRequest request);
    }
}
