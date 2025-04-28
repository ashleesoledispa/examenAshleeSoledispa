using System.ComponentModel.DataAnnotations;
using examenAshleeSoledispa.Models;

namespace examenAshleeSoledispa.Models
{
    public class Cliente
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio.")]
        [StringLength(100)]
        public string Nombre { get; set; }

        [Range(18, 100, ErrorMessage = "Edad debe ser entre 18 y 100.")]
        public int Edad { get; set; }

        [Range(0, 10000)]
        public decimal CreditoDisponible { get; set; }

        [EmailAddress(ErrorMessage = "Debe ser un email válido.")]
        public string Email { get; set; }

        [Display(Name = "Es miembro VIP")]
        public bool EsVIP { get; set; }

        [DataType(DataType.Date)]
        public DateTime FechaRegistro { get; set; }

        // Relaciones
        public ICollection<Reserva> Reservas { get; set; }
    }
}
