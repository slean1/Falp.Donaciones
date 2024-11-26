using System;

namespace Falp.Donaciones.Transversal.Comunes
{
    public class Response <T>
    {
        public T Data { get; set; }
        public bool IsSucess { get; set; }
        public string Message { get; set; }
    }
}
