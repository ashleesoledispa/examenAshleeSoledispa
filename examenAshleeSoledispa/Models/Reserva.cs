using System.ComponentModel.DataAnnotations;
using examenAshleeSoledispa.Models;

namespace examenAshleeSoledispa.Models;
    public class Reserva
    {
        public int Id { get; set; }

        [DataType(DataType.Date)]
        public DateTime FechaEntrada { get; set; }

        [DataType(DataType.Date)]
        public DateTime FechaSalida { get; set; }

        [Range(0, 10000)]
        public decimal ValorPagar { get; set; }

        // Relación
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
    }

