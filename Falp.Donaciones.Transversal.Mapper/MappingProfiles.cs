using System;
using Falp.Donaciones.Dominio.Entidad;
using Falp.Donaciones.Aplicacion.DTO;
using AutoMapper;

namespace Falp.Donaciones.Transversal.Mapper
{
    public class MappingProfiles: Profile
    {
        public MappingProfiles()
        {
            CreateMap<Donacion, DTODonaciones>().ReverseMap();
        }
    }
}
