using CAMADA_PRESENTATION_WEB.Entities;

namespace CAMADA_PRESENTATION_WEB.Interfaces.IRepositories
{
    public interface IClienteRepository
    {
        List<Cliente> Todos();
        Task<List<Cliente>> TodosAsync();

        Cliente Criar(Cliente cliente);
        Task<Cliente> CriarAsync(Cliente cliente);

        Cliente PegarPorId(Guid clienteId);
        Task<Cliente> PegarPorIdAsync(Guid clienteId);

        Cliente Editar(Cliente cliente, Guid clienteId);
        Task<Cliente> EditarAsync(Cliente cliente, Guid clienteId);

        void Deletar(Guid clienteId);
        Task DeletarAsync(Guid clienteId);        
    }
}
