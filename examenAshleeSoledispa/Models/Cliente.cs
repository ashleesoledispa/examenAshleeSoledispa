using System.ComponentModel.DataAnnotations;

namespace examenAshleeSoledispa.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }
        [Required]
        [Range(18, 100)]
        public int Edad { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        public decimal Saldo { get; set; }
        [Required]
        public bool EsVip { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime FechaRegistro { get; set; }
        public ICollection<Reserva> Reservas { get; set; }

    }
}
