using System.ComponentModel.DataAnnotations;

namespace examenAshleeSoledispa.Models
{
    public class PlanRecompensa
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime FechaInicio { get; set; }
        [Required]
        public int PuntosAcumulados { get; set; }
        [Required]
        public string TipoRecompensa
        {
            get
            {
                return PuntosAcumulados < 500 ? "SILVER" : "GOLD";
            }
        }
    }
}
