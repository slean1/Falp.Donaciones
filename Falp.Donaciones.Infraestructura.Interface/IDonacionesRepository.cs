using System;
using System.Collections.Generic;
using System.Text;
using Falp.Donaciones.Dominio.Entidad;

namespace Falp.Donaciones.Infraestructura.Interface
{
    public interface IDonacionesRepository
    {
        #region Métodos
        bool Insertar(Donacion Donacion);
        #endregion
    }
}
