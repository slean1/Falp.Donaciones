using System;
using Falp.Donaciones.Dominio.Entidad;
using Falp.Donaciones.Infraestructura.Interface;
using Falp.Donaciones.Transversal.Comunes;

namespace Falp.Donaciones.Infraestructura.Repositorio
{
    public class DonacionRepository: IDonacionesRepository
    {
        private readonly IConnectionFactory _connectionFactory;

        public DonacionRepository(IConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        #region Métodos
        public bool Insertar (Donacion donacion)
        {
            return true;
        }
        #endregion
    }
}
