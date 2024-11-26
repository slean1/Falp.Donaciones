using System;
using System.Collections.Generic;
using System.Text;
using Falp.Donaciones.Aplicacion.DTO;
using Falp.Donaciones.Transversal.Comunes;

namespace Falp.Donaciones.Aplicacion.Interface
{
    public interface IDonacionesAplicacion
    {
        #region Métodos
        Response<bool> Insertar(DTODonaciones DtoDonaciones);
        #endregion
    }
}
