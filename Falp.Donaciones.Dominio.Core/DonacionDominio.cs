using System;
using Falp.Donaciones.Dominio.Entidad;
using Falp.Donaciones.Dominio.Interface;
using Falp.Donaciones.Infraestructura.Interface;

namespace Falp.Donaciones.Dominio.Core
{
    public class DonacionDominio : IDonacionesDominio
    {
        private readonly IDonacionesRepository _donacionesRepository;

        public DonacionDominio(IDonacionesRepository donacionesRepository)
        {
            _donacionesRepository = donacionesRepository;
        }

        #region Métodos
        public bool Insertar (Donacion donacion)
        {
            return _donacionesRepository.Insertar(donacion);
        }
        #endregion
    }
}
