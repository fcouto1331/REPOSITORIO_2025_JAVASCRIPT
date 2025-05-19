using CAMADA_PRESENTATION_WEB.Dapper;
using CAMADA_PRESENTATION_WEB.Entities;
using CAMADA_PRESENTATION_WEB.Interfaces.IRepositories;
using Dapper;
using System.Text;

namespace CAMADA_PRESENTATION_WEB.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly DapperContext _context;

        public ClienteRepository(DapperContext context)
        {
            _context = context;
        }

        public List<Cliente> Todos()
        {
            using (var db = _context.CreateConnection())
            {
                StringBuilder query = new StringBuilder();
                query.Append("select ");
                query.Append("ClienteId, ");
                query.Append("Nome ");
                query.Append("from Cliente ");
                return [.. db.Query<Cliente>(query.ToString())]; //return db.Query<Cliente>(query.ToString()).ToList();
            }
        }

        public async Task<List<Cliente>> TodosAsync()
        {
            using (var db = _context.CreateConnection())
            {
                StringBuilder query = new StringBuilder();
                query.Append("select ");
                query.Append("ClienteId, ");
                query.Append("Nome ");
                query.Append("from Cliente ");
                var ret = await db.QueryAsync<Cliente>(query.ToString());
                return [.. ret]; //return ret.ToList();
            }
        }

        public Cliente Criar(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public Task<Cliente> CriarAsync(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public Cliente PegarPorId(Guid clienteId)
        {
            throw new NotImplementedException();
        }

        public Task<Cliente> PegarPorIdAsync(Guid clienteId)
        {
            throw new NotImplementedException();
        }

        public Cliente Editar(Cliente cliente, Guid clienteId)
        {
            throw new NotImplementedException();
        }

        public Task<Cliente> EditarAsync(Cliente cliente, Guid clienteId)
        {
            throw new NotImplementedException();
        }

        public void Deletar(Guid clienteId)
        {
            throw new NotImplementedException();
        }

        public Task DeletarAsync(Guid clienteId)
        {
            throw new NotImplementedException();
        }     
    }
}