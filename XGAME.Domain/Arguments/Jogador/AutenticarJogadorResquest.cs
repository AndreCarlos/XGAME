namespace XGAME.Domain.Arguments.Jogador
{
    public class AutenticarJogadorResquest
    {
        public string Email { get; set; }

        public string Senha { get; private set; }
    }
}
