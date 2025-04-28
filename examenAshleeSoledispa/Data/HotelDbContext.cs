using Microsoft.EntityFrameworkCore;
using examenAshleeSoledispa.Models; 

public class HotelDbContext : DbContext
{
    public HotelDbContext(DbContextOptions<HotelDbContext> options) : base(options) { }

    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<Reserva> Reservas { get; set; }
    public DbSet<PlanRecompensa> PlanesRecompensas { get; set; }
}
