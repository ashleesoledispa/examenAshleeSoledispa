using System.ComponentModel.DataAnnotations;

namespace examenAshleeSoledispa.Models
{
    public class Reserva
    {
        public int Id { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime FechaEntrada { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime FechaSalida { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        public decimal ValorPagar { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
    }
}
