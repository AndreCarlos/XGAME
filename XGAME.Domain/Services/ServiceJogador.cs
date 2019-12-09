using System;
using XGAME.Domain.Arguments.Jogador;
using XGAME.Domain.Interfaces.Repositories;
using XGAME.Domain.Interfaces.Services;

namespace XGAME.Domain.Services
{
    public class ServiceJogador : IServiceJogador
    {
        public ServiceJogador()
        {

        }

        private readonly IRepositoryJogador _repositoryJogador;

        public ServiceJogador(IRepositoryJogador repositoryJogador)
        {
            _repositoryJogador = repositoryJogador;
        }

        public AdicionarJogadorResponse AdicionarJogador(AdicionarJogadorRequest request)
        {
           Guid id = _repositoryJogador.AdicionarJogador(request);

            return new AdicionarJogadorResponse() { Id = id, Message = "Operacao realizada com sucesso!" };
        }

        public AutenticarJogadorResponse AutenticarJogador(AutenticarJogadorResquest request)
        {
            if (request == null)
            {
                throw new Exception("AutenticarJogadorRequest é obrigatório");
            }

            if (string.IsNullOrEmpty(request.Email))
            {
                throw new Exception("Informe um e-mail");
            }

            if (isEmail(request.Email))
            {
                throw new Exception("Informe um e-mail");
            }

            if (string.IsNullOrEmpty(request.Senha))
            {
                throw new Exception("Informe uma senha");
            }

            if ((request.Senha.Length < 6))
            {
                throw new Exception("Digite uma senha de no mínimo 6 caracteres");
            }

            var response =_repositoryJogador.AutenticarJogador(request);

            return response;
        }

        private bool isEmail(string email)
        {
            return false;
        }
    }
}