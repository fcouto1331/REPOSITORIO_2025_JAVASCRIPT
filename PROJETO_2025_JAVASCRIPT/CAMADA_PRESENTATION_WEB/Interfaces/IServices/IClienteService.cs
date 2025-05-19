using CAMADA_PRESENTATION_WEB.Entities;

namespace CAMADA_PRESENTATION_WEB.Interfaces.IServices
{
    public interface IClienteService
    {
        List<Cliente> Todos();
        Task<List<Cliente>> TodosAsync();
    }
}
