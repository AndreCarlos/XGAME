using System;
using XGAME.Domain.Enum;
using XGAME.Domain.ValueObjects;

namespace XGAME.Domain.Entities
{
    public class Jogador
    {
        public Guid Id { get; set; }

        public Nome Nome { get; set; }

        public Email Email { get; set; }

        public string Senha { get; private set; }

        public EnumSituacaoJogador Status { get; set; }
    }
}
