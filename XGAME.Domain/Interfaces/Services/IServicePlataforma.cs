using XGAME.Domain.Arguments.Plataforma;

namespace XGAME.Domain.Interfaces.Services
{
    public interface IServicePlataforma

    {
        AdicionarPlataformaResponse AdicionarPlataforma(AdicionarPlataformaRequest request);
    }
}
