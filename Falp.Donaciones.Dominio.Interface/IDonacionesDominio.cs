using System;
using System.Collections.Generic;
using System.Text;
using Falp.Donaciones.Dominio.Entidad;

namespace Falp.Donaciones.Dominio.Interface
{
    public interface IDonacionesDominio
    {
        #region Métodos
        bool Insertar(Donacion Donacion);
        #endregion
    }
}
