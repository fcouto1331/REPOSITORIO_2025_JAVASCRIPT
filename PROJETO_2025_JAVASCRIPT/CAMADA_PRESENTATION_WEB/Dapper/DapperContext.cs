using Microsoft.Data.SqlClient;
using System.Data;

namespace CAMADA_PRESENTATION_WEB.Dapper
{
    public class DapperContext
    {
        private readonly IConfiguration _configuration;
        private readonly string? _conexao;

        public DapperContext(IConfiguration configuration)
        {
            _configuration = configuration;
            _conexao = _configuration.GetConnectionString("conexao");
        }

        public IDbConnection CreateConnection() => new SqlConnection(_conexao);
    }
}
