using System;
using System.Collections.Generic;
using System.Text;
using Falp.Donaciones.Aplicacion.DTO;
using Falp.Donaciones.Aplicacion.Interface;
using Falp.Donaciones.Transversal.Comunes;
using Falp.Donaciones.Dominio.Entidad;
using Falp.Donaciones.Dominio.Interface;
using AutoMapper;

namespace Falp.Donaciones.Aplicacion.Main
{
    class DonacionApplication: IDonacionesAplicacion
    {
        private readonly IDonacionesDominio _donacionesDominio;
        private readonly IMapper _mapper;

        public DonacionApplication (IDonacionesDominio donacionDominio, IMapper mapper)
        {
            _donacionesDominio = donacionDominio;
            _mapper = mapper;
        }

        #region Métodos
        public Response<bool> Insertar(DTODonaciones dtoDonacion)
        {
            var response = new Response<bool>();
            try
            {
                var donacion = _mapper.Map<Donacion>(dtoDonacion);
                response.Data = _donacionesDominio.Insertar(donacion);
                if (response.Data)
                {
                    response.IsSucess = true;
                    response.Message = "Donación registrada";
                }
            }
            catch (Exception e)
            {
                response.Message = e.Message;
            }
            return response;
        }
        #endregion
    }
}
