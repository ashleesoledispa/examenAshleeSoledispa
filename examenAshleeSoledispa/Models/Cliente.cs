using System.ComponentModel.DataAnnotations;

namespace examenAshleeSoledispa.Models
{
    public class Cliente
    {
        [Key]
        public int ClienteId { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        [Range(18, 100)]
        public int Edad { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public bool EsVip { get; set; }

        [DataType(DataType.Date)]
        public DateTime FechaRegistro { get; set; }

        public ICollection<Reserva> Reservas { get; set; }
    }
}
