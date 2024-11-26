using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Falp.Donaciones.Transversal.Comunes
{
    public interface IConnectionFactory
    {
        IDbConnection GetConnection { get; }
    }
}
