using CAMADA_PRESENTATION_WEB.Entities;
using CAMADA_PRESENTATION_WEB.Interfaces.IRepositories;
using CAMADA_PRESENTATION_WEB.Interfaces.IServices;

namespace CAMADA_PRESENTATION_WEB.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;
        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public List<Cliente> GetAll()
        {
            return _clienteRepository.GetAll();
        }

        public async Task<List<Cliente>> GetAllAsync()
        {
            return await _clienteRepository.GetAllAsync();
        }
    }
}
