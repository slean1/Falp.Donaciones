using System;
using Falp.Donaciones.Transversal.Comunes;
using Microsoft.Extensions.Configuration;
using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace Falp.Donaciones.Infraestructura.Data
{
    public class ConnectionFactory: IConnectionFactory
    {
        private readonly IConfiguration _configuration;

        public ConnectionFactory(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IDbConnection GetConnection
        {
            get
            {
                var oracleConnection = new OracleConnection();
                if (oracleConnection == null) return null;
                return oracleConnection;
            }
        }
    }
}
