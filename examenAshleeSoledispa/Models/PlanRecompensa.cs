using System.ComponentModel.DataAnnotations;
using examenAshleeSoledispa.Models;

namespace examenAshleeSoledispa.Models
{
    public class PlanRecompensa
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        [DataType(DataType.Date)]
        public DateTime FechaInicio { get; set; }

        public int PuntosAcumulados { get; set; }

        public string TipoRecompensa
        {
            get
            {
                if (PuntosAcumulados < 500)
                    return "SILVER";
                else
                    return "GOLD";
            }
        }

        // Relación
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
    }
}
