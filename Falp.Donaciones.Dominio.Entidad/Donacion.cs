namespace Falp.Donaciones.Dominio.Entidad
{
    public class Donacion
    {
        public string Mandato { get; set; }
        public string Rut { get; set; }
        public string NroDocto { get; set; }
        public string TipoDonante { get; set; }
        public string FormaPago { get; set; }
        public string MontoCargado { get; set; }
        public string MesCobro { get; set; }
        public string CBeneficio { get; set; }
        public string FechaVcmto { get; set; }
        public string IdCargaPac { get; set; }
        public string FechaCarga { get; set; }
        public string FechaCaidaPago { get; set; }
        public string PeriodoCargo { get; set; }
        public string PeriodoCargoDos { get; set; }
        public string BancoCodigo { get; set; }
        public string IdParticipacion { get; set; }
        public string ProenCorrelativo { get; set; }
        public string CodAutorizacion { get; set; }
    }
}
