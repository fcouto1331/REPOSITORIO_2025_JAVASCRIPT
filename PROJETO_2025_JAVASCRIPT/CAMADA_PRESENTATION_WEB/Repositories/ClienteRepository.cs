using CAMADA_PRESENTATION_WEB.Dapper;
using CAMADA_PRESENTATION_WEB.Entities;
using CAMADA_PRESENTATION_WEB.Interfaces.IRepositories;
using Dapper;

namespace CAMADA_PRESENTATION_WEB.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly DapperContext _context;

        public ClienteRepository(DapperContext context)
        {
            _context = context;
        }

        public List<Cliente> GetAll()
        {
            using (var db = _context.CreateConnection())
            {
                var sql = "select ClienteId, Nome from Cliente";
                return [.. db.Query<Cliente>(sql)];
            }
        }
    }
}
